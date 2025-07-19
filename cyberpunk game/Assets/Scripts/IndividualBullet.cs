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

    public void SetPathCurved(bool recievedPathCurved)
    {
        pathCurved = recievedPathCurved;
    }
    public void SetCurveControlPoint(Vector3 recievedCurveControlPoint)
    {
        curveControlPoint = recievedCurveControlPoint;
    }
    public void SetCurveEndPoint(Vector3 recievedCurveEndPoint)
    {
        curveEndPoint = recievedCurveEndPoint;
    }
    public void SetMoveDelta(Vector2 recievedMoveDelta)
    {
        moveDelta = recievedMoveDelta;
    }

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + GameManager.Instance.bulletSpeedMultiplier * Time.deltaTime * moveDelta);
    }
}
