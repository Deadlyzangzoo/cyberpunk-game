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

    public void SetVariables(bool recievedPathCurved, Vector3 recievedCurveControlPoint, Vector3 recievedCurveEndPoint, Vector2 recievedMoveDelta)
    {
        pathCurved = recievedPathCurved;
        curveControlPoint = recievedCurveControlPoint;
        curveEndPoint = recievedCurveEndPoint;
        moveDelta = recievedMoveDelta;
    }

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + moveDelta * Time.deltaTime * GameManager.Instance.bulletSpeedMultiplier);

    }
}
