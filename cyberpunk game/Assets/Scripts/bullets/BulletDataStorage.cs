using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDataStorage {

    public BulletClass EmptyBulletData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, 0f);
        bullet.bulletNum = 0;
        bullet.timeBetweenBullets = 0f;
        bullet.pathCurved = false;
        bullet.curveControlPoint = Vector3.zero;
        bullet.curveEndPoint = Vector3.zero;
        bullet.bulletDirection = new Vector2(0f,0f);
        bullet.bulletDirectionChange = new Vector2(0f, 0f);
        bullet.locationChangeBetweenBullets = Vector3.zero;
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }

    public BulletClass TestBulletOneData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(1f, 0f);
        bullet.bulletNum = 3;
        bullet.timeBetweenBullets = 0.2f;
        bullet.pathCurved = false;
        bullet.curveControlPoint = Vector3.zero;
        bullet.curveEndPoint = Vector3.zero;
        bullet.bulletDirection = new Vector2(-1f, (float)-(System.Math.Tan(30)));
        bullet.bulletDirectionChange = new Vector2(0f, (float)System.Math.Tan(30));
        bullet.locationChangeBetweenBullets = Vector3.zero;
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.5f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }

    public BulletClass TestBulletTwoData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-1f, 0f);
        bullet.bulletNum = 3;
        bullet.timeBetweenBullets = 0.2f;
        bullet.pathCurved = false;
        bullet.curveControlPoint = Vector3.zero;
        bullet.curveEndPoint = Vector3.zero;
        bullet.bulletDirection = new Vector2(1f, (float)-(System.Math.Tan(30)));
        bullet.bulletDirectionChange = new Vector2(0f, (float)System.Math.Tan(30));
        bullet.locationChangeBetweenBullets = Vector3.zero;
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.5f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
}