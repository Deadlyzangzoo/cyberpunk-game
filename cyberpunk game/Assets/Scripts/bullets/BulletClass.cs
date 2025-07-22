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
    public float bulletTimeAlive;
    public bool bulletSolid;
    public bool dontDecay;
    public bool pathCurved;
    public Vector2[] randomSpawnBetween;
    public Vector2 bulletDirection;
    public float bulletDirectionChangeX;
    public float bulletDirectionChangeY;

    //added from bullet starting point
    public Vector3 curveControlPointOne;
    public Vector3 curveControlPointTwo;
    public Vector3 curveEndPoint;
    public Vector3 locationChangeBetweenBullets;
    public bool glitchedBulletGuaranteed;
    public float glitchedBulletChance;
    public int glitchedBulletNum;
    public int glitchedBulletAdjacentNum;

}