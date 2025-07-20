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
        bullet.bulletTimeAlive = 0f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = Vector3.zero;
        bullet.curveControlPointTwo = Vector3.zero;
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
        bullet.bulletTimeAlive = 20f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = Vector3.zero;
        bullet.curveControlPointTwo = Vector3.zero;
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
        bullet.bulletTimeAlive = 20f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = Vector3.zero;
        bullet.curveControlPointTwo = Vector3.zero;
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
    public BulletClass TestBulletCurveData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-2f, -0.65f);
        bullet.bulletNum = 5;
        bullet.timeBetweenBullets = 0.2f;
        bullet.bulletTimeAlive = 20f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-1f, 0.9f);
        bullet.curveControlPointTwo = new Vector3(1f, 0.9f);
        bullet.curveEndPoint = new Vector3(2f, -0.65f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = Vector3.zero;
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.2f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallShortLineLeftData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-2.5f, 0.5f);
        bullet.bulletNum = 21;
        bullet.timeBetweenBullets = 0.02f;
        bullet.bulletTimeAlive = 2.5f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(1.5f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f,-0.08f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.2f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallShortLineRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(2.5f, 0.5f);
        bullet.bulletNum = 21;
        bullet.timeBetweenBullets = 0.02f;
        bullet.bulletTimeAlive = 2.5f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-1.5f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, -0.08f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.2f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallShortLineTopData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-2.3f, 0.6f);
        bullet.bulletNum = 60;
        bullet.timeBetweenBullets = 0.005f;
        bullet.bulletTimeAlive = 1.5f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, -1.5f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0.08f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.2f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallShortLineBottomData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(2.3f, -1.2f);
        bullet.bulletNum = 60;
        bullet.timeBetweenBullets = 0.005f;
        bullet.bulletTimeAlive = 1.5f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, 1.5f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(-0.08f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.2f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }

    public BulletClass FirewallDiagonalLineLeftData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-2.4f, 0.52f);
        bullet.bulletNum = 21;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(1f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, -0.08f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallDiagonalLineRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(2.4f, 0.52f);
        bullet.bulletNum = 21;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-1f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, -0.08f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }

    public BulletClass FirewallUnmovingLineLeftData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-0.9f, 0.52f);
        bullet.bulletNum = 21;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 4.5f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, -0.08f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallUnmovingLineRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0.9f, 0.52f);
        bullet.bulletNum = 21;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 4.5f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, -0.08f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallFlamethrowerApproachData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0.9f, 0.52f);
        bullet.bulletNum = 50;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, -1f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(-0.036f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }

    public BulletClass FirewallSurpriseCurveUpData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0.3f, -2f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 2.2f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-2f, -0.6f);
        bullet.curveControlPointTwo = new Vector3(-1.3f, 1.1f);
        bullet.curveEndPoint = new Vector3(-0.2f, 0.6f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallContinuedCurveUpData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-0.2f, 0.6f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(0.5f, -0.5f);
        bullet.curveControlPointTwo = new Vector3(-2f, -0.7f);
        bullet.curveEndPoint = new Vector3(-3.2f, -0.9f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCurveHellOneData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(1.9f, 1.2f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-0.7f, 0.2f);
        bullet.curveControlPointTwo = new Vector3(1.6f, -0.8f);
        bullet.curveEndPoint = new Vector3(-0.4f, -1.2f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.3f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCurveHellTwoData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-3.4f, -1.4f);
        bullet.bulletNum = 15;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-1.6f, -1.8f);
        bullet.curveControlPointTwo = new Vector3(-1f, -0.1f);
        bullet.curveEndPoint = new Vector3(-2f, 1.3f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.3f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCurveHellThreeData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-3.5f, 0.1f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(0.6f, -1.5f);
        bullet.curveControlPointTwo = new Vector3(2.9f, -0.3f);
        bullet.curveEndPoint = new Vector3(3.5f, 0.9f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.3f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCurveHellFourData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(2.1f, 1f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-0.2f, 0.3f);
        bullet.curveControlPointTwo = new Vector3(1.8f, -1.1f);
        bullet.curveEndPoint = new Vector3(-1.1f, -1.8f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.3f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCurveHellFiveData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, 1.2f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-1f, 0f);
        bullet.curveControlPointTwo = new Vector3(1f, 0f);
        bullet.curveEndPoint = new Vector3(0f, -1.8f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.3f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCurveHellSixData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(3.4f, 2.3f);
        bullet.bulletNum = 40;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(0f, -1.8f);
        bullet.curveControlPointTwo = new Vector3(0f, 1.8f);
        bullet.curveEndPoint = new Vector3(-3.4f, -2.4f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.3f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCurveHellSevenData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0.5f, -2.1f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(1.3f, 0.2f);
        bullet.curveControlPointTwo = new Vector3(1.3f, -0.7f);
        bullet.curveEndPoint = new Vector3(0.5f, 1.5f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.3f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCurveHellEightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-0.5f, 1.5f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-1.3f, -0.7f);
        bullet.curveControlPointTwo = new Vector3(-1.3f, 0.2f);
        bullet.curveEndPoint = new Vector3(-0.5f, -2.1f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.3f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCircleSpamOneRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, -1.2f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(1.3f, -0.8f);
        bullet.curveControlPointTwo = new Vector3(1.3f, 0.3f);
        bullet.curveEndPoint = new Vector3(0f, 0.6f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.3f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCircleSpamOneLeftData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, 0.6f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-1.3f, 0.3f);
        bullet.curveControlPointTwo = new Vector3(-1.3f, -0.8f);
        bullet.curveEndPoint = new Vector3(0f, -1.2f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.3f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCircleSpamTwoRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(1.2f, -1.2f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(2.5f, -0.8f);
        bullet.curveControlPointTwo = new Vector3(2.5f, 0.3f);
        bullet.curveEndPoint = new Vector3(1.2f, 0.6f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.3f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCircleSpamTwoLeftData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(1.2f, 0.6f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-0.1f, 0.3f);
        bullet.curveControlPointTwo = new Vector3(-0.1f, -0.8f);
        bullet.curveEndPoint = new Vector3(1.2f, -1.2f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.3f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCircleSpamThreeRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-1.2f, -1.2f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(0.1f, -0.8f);
        bullet.curveControlPointTwo = new Vector3(0.1f, 0.3f);
        bullet.curveEndPoint = new Vector3(-1.2f, 0.6f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.3f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCircleSpamThreeLeftData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-1.2f, 0.6f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.08f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-2.5f, 0.3f);
        bullet.curveControlPointTwo = new Vector3(-2.5f, -0.8f);
        bullet.curveEndPoint = new Vector3(-1.2f, -1.2f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.3f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
}