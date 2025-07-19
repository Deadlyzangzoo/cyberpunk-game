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
        bullet.bulletDirectionChangeX = 0f;
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
        bullet.timeBetweenBullets = 0f;
        bullet.pathCurved = false;
        bullet.curveControlPoint = Vector3.zero;
        bullet.curveEndPoint = Vector3.zero;
        bullet.bulletDirection = new Vector2(-0.5f, (float)(System.Math.Tan(-10)));
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = (float)System.Math.Tan(10);
        bullet.locationChangeBetweenBullets = Vector3.zero;
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 1f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }

    public BulletClass TestBulletTwoData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-1f, -0.3f);
        bullet.bulletNum = 3;
        bullet.timeBetweenBullets = 0f;
        bullet.pathCurved = false;
        bullet.curveControlPoint = Vector3.zero;
        bullet.curveEndPoint = Vector3.zero;
        bullet.bulletDirection = new Vector2(0.5f, (float)(System.Math.Tan(-10)));
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = (float)System.Math.Tan(10);
        bullet.locationChangeBetweenBullets = Vector3.zero;
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 1f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
}