using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class BulletClass
{
    public Vector3 startLocation;
    public int bulletNum;
    public float timeBetweenBullets;
    public bool pathCurved;
    public Vector2 bulletDirection;
    public Vector2 bulletDirectionChange;

    //added from bullet starting point
    public Vector3 curveControlPoint;
    public Vector3 curveEndPoint;
    public Vector3 locationChangeBetweenBullets;

    public bool glitchedBulletGuaranteed;
    public float glitchedBulletChance;
    public int glitchedBulletNum;
    public int glitchedBulletAdjacentNum;

}