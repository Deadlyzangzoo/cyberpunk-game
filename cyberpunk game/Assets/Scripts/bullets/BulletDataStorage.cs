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
        bullet.bulletDirection = new Vector2(-0.5f, (float)(System.Math.Tan(-30 * Mathf.PI / 180)));
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = (float)System.Math.Tan(30 * Mathf.PI / 180);
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
        bullet.bulletDirection = new Vector2(0.5f, (float)(System.Math.Tan(-30 * Mathf.PI / 180)));
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = (float)System.Math.Tan(30 * Mathf.PI / 180);
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

        bullet.startLocation = new Vector3(-4.3f, 1f);
        bullet.bulletNum = 29;
        bullet.timeBetweenBullets = 0.02f;
        bullet.bulletTimeAlive = 3f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(2f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f,-0.11f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.2f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallShortLineRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(4.3f, 1f);
        bullet.bulletNum = 29;
        bullet.timeBetweenBullets = 0.02f;
        bullet.bulletTimeAlive = 3f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-2f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, -0.11f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.2f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallShortLineTopData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-4.3f, 1f);
        bullet.bulletNum = 80;
        bullet.timeBetweenBullets = 0.005f;
        bullet.bulletTimeAlive = 2f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, -2f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0.11f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.2f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallShortLineBottomData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(4.3f, -2.15f);
        bullet.bulletNum = 80;
        bullet.timeBetweenBullets = 0.005f;
        bullet.bulletTimeAlive = 2f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, 2f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(-0.11f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.2f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }

    public BulletClass FirewallDiagonalLineLeftData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-4.3f, 1f);
        bullet.bulletNum = 29;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 4f;
        bullet.pathCurved = false;
        bullet.dontDecay = true;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(1.5f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, -0.11f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallDiagonalLineRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(4.3f, 1f);
        bullet.bulletNum = 29;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 4f;
        bullet.pathCurved = false;
        bullet.dontDecay = true;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-1.5f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, -0.11f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }

    public BulletClass FirewallUnmovingLineLeftData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-1.3f, 1f);
        bullet.bulletNum = 29;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 2f;
        bullet.bulletSolid = true;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, -0.11f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallUnmovingLineRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(1.3f, 1f);
        bullet.bulletNum = 29;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 2f;
        bullet.bulletSolid = true;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, -0.11f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallFlamethrowerApproachData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(1.3f, 1f);
        bullet.bulletNum = 26;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, -2f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(-0.10f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }

    public BulletClass FirewallSurpriseCurveUpData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0.3f, -2.2f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 2.2f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-2.7f, -0.7f);
        bullet.curveControlPointTwo = new Vector3(-1.3f, 2.7f);
        bullet.curveEndPoint = new Vector3(0f, 1f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.4f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallContinuedCurveUpData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, 1f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(0.5f, -0.5f);
        bullet.curveControlPointTwo = new Vector3(-1.9f, -1.5f);
        bullet.curveEndPoint = new Vector3(-5.3f, -2f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.4f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallCurveHellOneData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(1.9f, 1.2f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-1f, 0.7f);
        bullet.curveControlPointTwo = new Vector3(2.4f, -1.5f);
        bullet.curveEndPoint = new Vector3(-0.5f, -2.4f);
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

        bullet.startLocation = new Vector3(-4.9f, -1.4f);
        bullet.bulletNum = 15;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-2.5f, -2.3f);
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

        bullet.startLocation = new Vector3(-5f, 0.5f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-2.4f, -1.7f);
        bullet.curveControlPointTwo = new Vector3(2.9f, -1.7f);
        bullet.curveEndPoint = new Vector3(3.5f, 1.2f);
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

        bullet.startLocation = new Vector3(3.5f, 3f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-1.1f, 1f);
        bullet.curveControlPointTwo = new Vector3(3.3f, -1.7f);
        bullet.curveEndPoint = new Vector3(-1.1f, -2.7f);
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
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-1f, 0f);
        bullet.curveControlPointTwo = new Vector3(1f, 0f);
        bullet.curveEndPoint = new Vector3(0f, -2.6f);
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

        bullet.startLocation = new Vector3(5.6f, 2.3f);
        bullet.bulletNum = 40;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(0f, -1.8f);
        bullet.curveControlPointTwo = new Vector3(0f, 1.8f);
        bullet.curveEndPoint = new Vector3(-5.6f, -2.4f);
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

        bullet.startLocation = new Vector3(1.05f, -2.2f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(2.35f, 0.2f);
        bullet.curveControlPointTwo = new Vector3(2.35f, -0.7f);
        bullet.curveEndPoint = new Vector3(1.05f, 1.5f);
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

        bullet.startLocation = new Vector3(-1.05f, 1.5f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-2.35f, -0.7f);
        bullet.curveControlPointTwo = new Vector3(-2.35f, 0.2f);
        bullet.curveEndPoint = new Vector3(-1.05f, -2.2f);
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

        bullet.startLocation = new Vector3(0f, -2.1f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(1.5f, -1f);
        bullet.curveControlPointTwo = new Vector3(1.5f, 0.3f);
        bullet.curveEndPoint = new Vector3(0f, 1f);
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

        bullet.startLocation = new Vector3(0f, 1f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-1.5f, 0.3f);
        bullet.curveControlPointTwo = new Vector3(-1.5f, -1f);
        bullet.curveEndPoint = new Vector3(0f, -2.1f);
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

        bullet.startLocation = new Vector3(1.2f, -2.1f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(2.7f, -1f);
        bullet.curveControlPointTwo = new Vector3(2.7f, 0.3f);
        bullet.curveEndPoint = new Vector3(1.2f, 1f);
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

        bullet.startLocation = new Vector3(1.2f, 1f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-0.3f, 0.3f);
        bullet.curveControlPointTwo = new Vector3(-0.3f, -1f);
        bullet.curveEndPoint = new Vector3(1.2f, -2.1f);
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

        bullet.startLocation = new Vector3(-1.2f, -2.1f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(0.3f, -1f);
        bullet.curveControlPointTwo = new Vector3(0.3f, 0.3f);
        bullet.curveEndPoint = new Vector3(-1.2f, 1f);
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

        bullet.startLocation = new Vector3(-1.2f, 1f);
        bullet.bulletNum = 30;
        bullet.timeBetweenBullets = 0.11f;
        bullet.bulletTimeAlive = 3.5f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-2.7f, 0.3f);
        bullet.curveControlPointTwo = new Vector3(-2.7f, -1f);
        bullet.curveEndPoint = new Vector3(-1.2f, -2.1f);
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
    public BulletClass FirewallWallOfDoomRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(4.3f, 1f);
        bullet.bulletNum = 29;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 13f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-1.5f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, -0.11f);
        bullet.glitchedBulletGuaranteed = true;
        bullet.glitchedBulletChance = 0.1f;
        bullet.glitchedBulletNum = 6;
        bullet.glitchedBulletAdjacentNum = 6;

        return bullet;
    }
    public BulletClass FirewallWallOfDoomTopData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-4.3f, 1f);
        bullet.bulletNum = 80;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 10f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, -1f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0.11f, 0f);
        bullet.glitchedBulletGuaranteed = true;
        bullet.glitchedBulletChance = 0.035f;
        bullet.glitchedBulletNum = 5;
        bullet.glitchedBulletAdjacentNum = 5;

        return bullet;
    }
    public BulletClass FirewallWallOfDoomDiagonalTopRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, 5f);
        bullet.bulletNum = 55;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 10f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-1f, -1f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0.11f, -0.11f);
        bullet.glitchedBulletGuaranteed = true;
        bullet.glitchedBulletChance = 0.05f;
        bullet.glitchedBulletNum = 7;
        bullet.glitchedBulletAdjacentNum = 7;

        return bullet;
    }
    public BulletClass FirewallScaryWallDiagonalTopRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, 5f);
        bullet.bulletNum = 55;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 7.5f;
        bullet.pathCurved = false;
        bullet.dontDecay = true;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-1f, -1f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0.11f, -0.11f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallUnmovingWallDiagonalTopRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-3.75f, 1.25f);
        bullet.bulletNum = 45;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 20f;
        bullet.bulletSolid = true;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0.11f, -0.11f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallTightSpaceCurveSpamOneData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-1.5f, 1.4f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.16f;
        bullet.bulletTimeAlive = 3f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-0.5f, 0.1f);
        bullet.curveControlPointTwo = new Vector3(-2.8f, -3f);
        bullet.curveEndPoint = new Vector3(-6.4f, -1.5f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.2f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallTightSpaceCurveSpamTwoData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(3.7f, 0f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.16f;
        bullet.bulletTimeAlive = 3f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(0.8f, 0.7f);
        bullet.curveControlPointTwo = new Vector3(-1.7f, 0.8f);
        bullet.curveEndPoint = new Vector3(-2.7f, -2.6f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.2f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallTightSpaceCurveSpamThreeData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(3.8f, 0f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.16f;
        bullet.bulletTimeAlive = 3f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-0.6f, 0f);
        bullet.curveControlPointTwo = new Vector3(-2.6f, -1.1f);
        bullet.curveEndPoint = new Vector3(-1.5f, 2f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.2f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass FirewallTightSpaceCurveSpamFourData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-4.7f, -2.5f);
        bullet.bulletNum = 40;
        bullet.timeBetweenBullets = 0.16f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-1.7f, -1.6f);
        bullet.curveControlPointTwo = new Vector3(-1.6f, 0.2f);
        bullet.curveEndPoint = new Vector3(-2.6f, 2.4f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.2f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }

    public BulletClass TeamRandomRightBulletSpamData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(4.3f, 0f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.5f;
        bullet.bulletTimeAlive = 6f;
        bullet.randomSpawnBetween = new Vector2[2]
        {
            new Vector2(4.3f, -2),
            new Vector2(4.3f, 1)
        };
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-4f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.4f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamRandomTopBulletSpamData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, 1f);
        bullet.bulletNum = 100;
        bullet.timeBetweenBullets = 0.1f;
        bullet.bulletTimeAlive = 6f;
        bullet.randomSpawnBetween = new Vector2[2]
        {
            new Vector2(-4.3f, 1),
            new Vector2(4.3f, 1)
        };
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, -4f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.4f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombMiddleLRData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, 0f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(2f, 0f);
        bullet.bulletDirectionChangeX = -4f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombMiddleUDData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, 0f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, 2f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = -4f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombTopLeftLRData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-2.5f, 0f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(2f, 0f);
        bullet.bulletDirectionChangeX = -4f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombTopLeftUDData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-2.5f, 0f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, 2f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = -4f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombBottomRightLRData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(2f, -1.5f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(2f, 0f);
        bullet.bulletDirectionChangeX = -4f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombBottomRightUDData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(2f, -1.5f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, 2f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = -4f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombMiddleLeftLRData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-1f, -0.5f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(2f, 0f);
        bullet.bulletDirectionChangeX = -4f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombMiddleLeftUDData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-1f, -0.5f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, 2f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = -4f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombTopRightLRData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(2f, 0.5f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-1.42f, 1.42f);
        bullet.bulletDirectionChangeX = 2.84f;
        bullet.bulletDirectionChangeY = -2.84f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombTopRightUDData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(2f, 0.5f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(1.42f, 1.42f);
        bullet.bulletDirectionChangeX = -2.84f;
        bullet.bulletDirectionChangeY = -2.84f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombTopMiddleLRData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, 0f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-1.42f, 1.42f);
        bullet.bulletDirectionChangeX = 2.84f;
        bullet.bulletDirectionChangeY = -2.84f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombTopMiddleUDData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, 0f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(1.42f, 1.42f);
        bullet.bulletDirectionChangeX = -2.84f;
        bullet.bulletDirectionChangeY = -2.84f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombMiddleRightLRData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(2f, -0.3f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(2f, 0f);
        bullet.bulletDirectionChangeX = -4f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombMiddleRightUDData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(2f, -0.3f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, 2f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = -4f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombBottomMiddleLRData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, -1f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-1.42f, 1.42f);
        bullet.bulletDirectionChangeX = 2.84f;
        bullet.bulletDirectionChangeY = -2.84f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombBottomMiddleUDData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, -1f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(1.42f, 1.42f);
        bullet.bulletDirectionChangeX = -2.84f;
        bullet.bulletDirectionChangeY = -2.84f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombBottomLeftLRData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-1f, -1.5f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-1.42f, 1.42f);
        bullet.bulletDirectionChangeX = 2.84f;
        bullet.bulletDirectionChangeY = -2.84f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombBottomLeftUDData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-1f, -1.5f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(1.42f, 1.42f);
        bullet.bulletDirectionChangeX = -2.84f;
        bullet.bulletDirectionChangeY = -2.84f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombMiddleDiagonalLRData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, -1f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-1.42f, 1.42f);
        bullet.bulletDirectionChangeX = 2.84f;
        bullet.bulletDirectionChangeY = -2.84f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBombMiddleDiagonalUDData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, -1f);
        bullet.bulletNum = 2;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(1.42f, 1.42f);
        bullet.bulletDirectionChangeX = -2.84f;
        bullet.bulletDirectionChangeY = -2.84f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamLeftCurveDownData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(4.3f, 1f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.2f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(-2.7f, 0.5f);
        bullet.curveControlPointTwo = new Vector3(-2.6f, -1.3f);
        bullet.curveEndPoint = new Vector3(-3f, -3f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(-0.05f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamRightCurveDownData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-4.3f, 1f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.2f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = true;
        bullet.curveControlPointOne = new Vector3(2.7f, 0.5f);
        bullet.curveControlPointTwo = new Vector3(2.6f, -1.3f);
        bullet.curveEndPoint = new Vector3(3f, -3f);
        bullet.bulletDirection = new Vector2(0f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0.05f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBottomLeftTurretData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-2.15f, -2.2f);
        bullet.bulletNum = 3;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2((float)System.Math.Tan(-30 * Mathf.PI / 180), 2f);
        bullet.bulletDirectionChangeX = (float)System.Math.Tan(30 * Mathf.PI / 180);
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBottomMiddleTurretData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, -2.2f);
        bullet.bulletNum = 3;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2((float)System.Math.Tan(-30 * Mathf.PI / 180), 2f);
        bullet.bulletDirectionChangeX = (float)System.Math.Tan(30 * Mathf.PI / 180);
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamBottomRightTurretData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(2.15f, -2.2f);
        bullet.bulletNum = 3;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2((float)System.Math.Tan(-30 * Mathf.PI / 180), 2f);
        bullet.bulletDirectionChangeX = (float)System.Math.Tan(30 * Mathf.PI / 180);
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamTopLeftTurretData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-2.15f, 1f);
        bullet.bulletNum = 3;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2((float)System.Math.Tan(-30 * Mathf.PI / 180), -2f);
        bullet.bulletDirectionChangeX = (float)System.Math.Tan(30 * Mathf.PI / 180);
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamTopMiddleTurretData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, 1f);
        bullet.bulletNum = 3;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2((float)System.Math.Tan(-30 * Mathf.PI / 180), -2f);
        bullet.bulletDirectionChangeX = (float)System.Math.Tan(30 * Mathf.PI / 180);
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamTopRightTurretData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(2.15f, 1f);
        bullet.bulletNum = 3;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2((float)System.Math.Tan(-30 * Mathf.PI / 180), -2f);
        bullet.bulletDirectionChangeX = (float)System.Math.Tan(30 * Mathf.PI / 180);
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamLeftTurretData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(-4.3f, -1f);
        bullet.bulletNum = 3;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(2f, (float)System.Math.Tan(-30 * Mathf.PI / 180));
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = (float)System.Math.Tan(30 * Mathf.PI / 180);
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamRightTurretData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(4.3f, -1f);
        bullet.bulletNum = 3;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-2f, (float)System.Math.Tan(-30 * Mathf.PI / 180));
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = (float)System.Math.Tan(30 * Mathf.PI / 180);
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.6f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamSpinnyBallRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, -0.5f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.1f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(1.5f, -1.5f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0.15f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.4f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamSpinnyBallTopData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, -0.5f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.1f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(1.5f, 1.5f);
        bullet.bulletDirectionChangeX = -0.15f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.4f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamSpinnyBallLeftData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, -0.5f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.1f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-1.5f, 1.5f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = -0.15f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.4f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamSpinnyBallBottomData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, -0.5f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.1f;
        bullet.bulletTimeAlive = 6f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-1.5f, -1.5f);
        bullet.bulletDirectionChangeX = 0.15f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.4f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamRandomRightBulletSlowData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(4.3f, 0f);
        bullet.bulletNum = 20;
        bullet.timeBetweenBullets = 0.7f;
        bullet.bulletTimeAlive = 9f;
        bullet.randomSpawnBetween = new Vector2[2]
        {
            new Vector2(4.3f, -2),
            new Vector2(4.3f, 1)
        };
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-2f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.4f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TeamRandomTopBulletSlowData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(0f, 2f);
        bullet.bulletNum = 100;
        bullet.timeBetweenBullets = 0.2f;
        bullet.bulletTimeAlive = 8f;
        bullet.randomSpawnBetween = new Vector2[2]
        {
            new Vector2(-4.3f, 2),
            new Vector2(4.3f, 2)
        };
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(0f, -2f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.4f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TutorialRandomRightBulletData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(4.3f, 0f);
        bullet.bulletNum = 50;
        bullet.timeBetweenBullets = 0.2f;
        bullet.bulletTimeAlive = 9f;
        bullet.randomSpawnBetween = new Vector2[2]
        {
            new Vector2(4.3f, -2),
            new Vector2(4.3f, 2)
        };
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-3f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TutorialSingleGlitchedBulletRightData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(4.3f, -0.5f);
        bullet.bulletNum = 1;
        bullet.timeBetweenBullets = 0f;
        bullet.bulletTimeAlive = 9f;
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-2f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = true;
        bullet.glitchedBulletChance = 0f;
        bullet.glitchedBulletNum = 1;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
    public BulletClass TutorialRandomRightBulletGlitchedData()
    {
        BulletClass bullet = new();

        bullet.startLocation = new Vector3(4.3f, 0f);
        bullet.bulletNum = 100;
        bullet.timeBetweenBullets = 0.2f;
        bullet.bulletTimeAlive = 9f;
        bullet.randomSpawnBetween = new Vector2[2]
        {
            new Vector2(4.3f, -2),
            new Vector2(4.3f, 2)
        };
        bullet.pathCurved = false;
        bullet.curveControlPointOne = new Vector3(0f, 0f);
        bullet.curveControlPointTwo = new Vector3(0f, 0f);
        bullet.curveEndPoint = new Vector3(0f, 0f);
        bullet.bulletDirection = new Vector2(-3f, 0f);
        bullet.bulletDirectionChangeX = 0f;
        bullet.bulletDirectionChangeY = 0f;
        bullet.locationChangeBetweenBullets = new Vector3(0f, 0f);
        bullet.glitchedBulletGuaranteed = false;
        bullet.glitchedBulletChance = 0.5f;
        bullet.glitchedBulletNum = 0;
        bullet.glitchedBulletAdjacentNum = 0;

        return bullet;
    }
}