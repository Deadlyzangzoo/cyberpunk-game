using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IndividualBullet : MonoBehaviour
{
    public bool pathCurved;
    public Vector3 curveControlPointOne;
    public Vector3 curveControlPointTwo;
    public Vector3 curveEndPoint;
    public Vector2 moveDelta;
    public float timeAlive;
    private Rigidbody2D rigidBody;
    public bool blockPathCurved;
    public bool blockCurveControlPointOne;
    public bool blockCurveControlPointTwo;
    public bool blockCurveEndPoint;
    public bool blockMoveDelta;
    public bool blockTimeAlive;
    public bool isThisBulletGlitched;
    public float lerp;
    public Vector3 startLocation;
    public Vector2 result;
    public bool deflected;
    public Vector3 deflectCurveControlPointOne;
    public Vector3 deflectCurveControlPointTwo;
    public Vector3 deflectCurveEndPoint;
    public bool deflectStarted;


    public void SetPathCurved(bool recievedPathCurved)
    {
        if (!blockPathCurved)
        {
            pathCurved = recievedPathCurved;
            blockPathCurved = true;
        }
        
    }
    public void SetCurveControlPointOne(Vector3 recievedCurveControlPointOne)
    {
        if (!blockCurveControlPointOne)
        {
            curveControlPointOne = recievedCurveControlPointOne;
            blockCurveControlPointOne = true;
        }
        
    }
    public void SetCurveControlPointTwo(Vector3 recievedCurveControlPointTwo)
    {
        if (!blockCurveControlPointTwo)
        {
            curveControlPointTwo = recievedCurveControlPointTwo;
            blockCurveControlPointTwo = true;
        }

    }
    public void SetCurveEndPoint(Vector3 recievedCurveEndPoint)
    {
        if (!blockCurveEndPoint)
        {
            curveEndPoint = recievedCurveEndPoint;
            blockCurveEndPoint = true;
        }
        
    }
    public void SetMoveDelta(Vector2 recievedMoveDelta)
    {
        if (!blockMoveDelta)
        {
            moveDelta = recievedMoveDelta;
            blockMoveDelta = true;
        }
        
    }
    public void SetTimeAlive(float recievedTimeAlive)
    {
        if (!blockTimeAlive)
        {
            timeAlive = recievedTimeAlive;
            blockTimeAlive = true;
        }

    }

    private void Start()
    {
        deflectStarted = false;
        deflected = false;
        lerp = 0;
        rigidBody = GetComponent<Rigidbody2D>();
        StartCoroutine(CountDownToGettingDeleted(timeAlive));
        startLocation=rigidBody.position;
    }
    private void FixedUpdate()
    {
        if (!deflected)
        {
            if (pathCurved)
            {
                if (lerp < 1)
                {
                    rigidBody.MovePosition(CalculateBezierPoint(lerp, startLocation, curveControlPointOne, curveControlPointTwo, curveEndPoint));
                    lerp += Time.deltaTime * GameManager.Instance.bulletSpeedMultiplier;
                }
                else
                {
                    GameObject.Destroy(gameObject);
                }
            }
            else
            {
                rigidBody.MovePosition(rigidBody.position + GameManager.Instance.bulletSpeedMultiplier * Time.deltaTime * moveDelta);
            }
        }
        else
        {
            if (!deflectStarted)
            {
                startLocation = rigidBody.position;
                deflectStarted = true;
                deflectCurveEndPoint = new Vector3(0f, 1f);
                if (startLocation.x <= 0)
                {
                    deflectCurveControlPointOne = new Vector3(-3f, 0f);
                    deflectCurveControlPointTwo = new Vector3(-1.5f, 1.5f);
                }
                else
                {
                    deflectCurveControlPointOne = new Vector3(3f, 0f);
                    deflectCurveControlPointTwo = new Vector3(1.5f, 1.5f);
                }
            }
            if (lerp < 1)
            {
                rigidBody.MovePosition(CalculateBezierPoint(lerp, startLocation, deflectCurveControlPointOne, deflectCurveControlPointTwo, deflectCurveEndPoint));
                if (lerp < 0.3)
                {
                    lerp += Time.deltaTime * GameManager.Instance.bulletSpeedMultiplier * 0.6f * 1.5f;
                }
                else
                {
                    lerp += Time.deltaTime * GameManager.Instance.bulletSpeedMultiplier * 1.5f;
                }
            }
            else
            {
                GameObject.Destroy(gameObject);
            }
        }
    }
    private IEnumerator CountDownToGettingDeleted(float timeAlive)
    {
        float timePassed = 0f;
        while (timePassed < timeAlive)
        {
            yield return new WaitForEndOfFrame();
            timePassed = timePassed + (Time.deltaTime * (GameManager.Instance.bulletSpeedMultiplier/0.5f));
        }
        if (!deflected)
        {
            GameObject.Destroy(gameObject);
        }
        
    }
    public void Deflect()
    {
        deflected=true;
        gameObject.layer = 10;
        lerp=0;
    }

    private Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
    {
        Vector3 result = Mathf.Pow(1 - t, 3) * p0 + 3 * Mathf.Pow(1 - t, 2) * t * p1 + 3 * (1 - t) * Mathf.Pow(t, 2) * p2 + Mathf.Pow(t, 3) * p3;
        return result;
    }
}
