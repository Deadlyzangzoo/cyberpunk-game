using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndividualBullet : MonoBehaviour
{
    public bool pathCurved;
    public Vector3 curveControlPoint;
    public Vector3 curveEndPoint;
    public Vector2 moveDelta;
    private Rigidbody2D rigidBody;
    public SpriteRenderer spriteRenderer;
    public bool blockPathCurved;
    public bool blockCurveControlPoint;
    public bool blockCurveEndPoint;
    public bool blockMoveDelta;

    public void SetPathCurved(bool recievedPathCurved)
    {
        if (!blockPathCurved)
        {
            pathCurved = recievedPathCurved;
            blockPathCurved = true;
        }
        
    }
    public void SetCurveControlPoint(Vector3 recievedCurveControlPoint)
    {
        if (!blockCurveControlPoint)
        {
            curveControlPoint = recievedCurveControlPoint;
            blockCurveControlPoint = true;
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

    private void Start()
    {
        spriteRenderer.color = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F));
        rigidBody = GetComponent<Rigidbody2D>();
        StartCoroutine(CountDownToGettingDeleted());
    }
    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + GameManager.Instance.bulletSpeedMultiplier * Time.deltaTime * moveDelta);
    }
    private IEnumerator CountDownToGettingDeleted()
    {
        yield return new WaitForSeconds(20f);
        GameObject.Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerController.Instance.health -= 20;
        GameObject.Destroy (gameObject);
    }
}
