using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class fakeNController : MonoBehaviour
{
    private float lerp;
    private bool deflectStarted;
    private Vector2 startLocation;
    private Vector2 deflectCurveEndPoint;
    private Vector2 deflectCurveControlPointOne;
    private Vector2 deflectCurveControlPointTwo;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Deflect()
    {
        gameObject.layer = 10;
        lerp = 0;
        if (!deflectStarted)
        {
            startLocation = transform.position;
            deflectStarted = true;
            deflectCurveEndPoint = new Vector3(-0.1f, -1f);
            deflectCurveControlPointOne = new Vector3(-3.4f, -0.5f);
            deflectCurveControlPointTwo = new Vector3(-1.7f, -1.4f);
        }
    }
    private void FixedUpdate()
    {
        if (deflectStarted)
        {
            if (lerp < 1)
            {
                rb.MovePosition(CalculateBezierPoint(lerp, startLocation, deflectCurveControlPointOne, deflectCurveControlPointTwo, deflectCurveEndPoint));
                lerp += Time.deltaTime;
            }
            TextController.Instance.fakeNInPosition = true;
        }
    }


    private Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
    {
        Vector3 result = Mathf.Pow(1 - t, 3) * p0 + 3 * Mathf.Pow(1 - t, 2) * t * p1 + 3 * (1 - t) * Mathf.Pow(t, 2) * p2 + Mathf.Pow(t, 3) * p3;
        return result;
    }
}
