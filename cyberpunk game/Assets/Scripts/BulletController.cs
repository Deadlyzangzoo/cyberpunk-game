using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public static BulletController Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType(typeof(BulletController)) as BulletController;

            return _instance;
        }
        set
        {
            _instance = value;
        }
    }

    private static BulletController _instance;

    public string[] bulletGroupList;
    public GameObject bulletSpawnerPrefab;


    void Awake()
    {
        bulletGroupList = new string[30]
        {
            "EmptyBulletData",
            "TestBullet1",
            "TestBullet2",
            "TestBulletCurve",
            "BulletShortLineLeft",
            "BulletShortLineRight",
            "BulletShortLineTop",
            "BulletShortLineBottom",
            "BulletDiagonalLineLeft",
            "BulletDiagonalLineRight",
            "BulletUnmovingLineLeft",
            "BulletUnmovingLineRight",
            "BulletFlamethrowerApproach",
            "BulletSurpriseCurveUp",
            "BulletSurpriseCurveContinue",
            "BulletCurveHellOne",
            "BulletCurveHellTwo",
            "BulletCurveHellThree",
            "BulletCurveHellFour",
            "BulletCurveHellFive",
            "BulletCurveHellSix",
            "BulletCurveHellSeven",
            "BulletCurveHellEight",
            "BulletCircleSpamOneRight",
            "BulletCircleSpamOneLeft",
            "BulletCircleSpamTwoRight",
            "BulletCircleSpamTwoLeft",
            "BulletCircleSpamThreeRight",
            "BulletCircleSpamThreeLeft",
            "BulletWallOfDoomRight",
        };
    }


    public void StartSpawningBulletGroup(string groupname)
    {
        BulletDataStorage bulletData = new();
        BulletClass newBulletGroup = bulletData.EmptyBulletData();
        if (groupname == bulletGroupList[1])
        {
            newBulletGroup = bulletData.TestBulletOneData();
        }
        else if (groupname == bulletGroupList[2])
        {
            newBulletGroup = bulletData.TestBulletTwoData();
        }
        else if (groupname == bulletGroupList[3])
        {
            newBulletGroup = bulletData.TestBulletCurveData();
        }
        else if (groupname == bulletGroupList[4])
        {
            newBulletGroup = bulletData.FirewallShortLineLeftData();
        }
        else if (groupname == bulletGroupList[5])
        {
            newBulletGroup = bulletData.FirewallShortLineRightData();
        }
        else if (groupname == bulletGroupList[6])
        {
            newBulletGroup = bulletData.FirewallShortLineTopData();
        }
        else if (groupname == bulletGroupList[7])
        {
            newBulletGroup = bulletData.FirewallShortLineBottomData();
        }
        else if (groupname == bulletGroupList[8])
        {
            newBulletGroup = bulletData.FirewallDiagonalLineLeftData();
        }
        else if (groupname == bulletGroupList[9])
        {
            newBulletGroup = bulletData.FirewallDiagonalLineRightData();
        }
        else if (groupname == bulletGroupList[10])
        {
            newBulletGroup = bulletData.FirewallUnmovingLineLeftData();
        }
        else if (groupname == bulletGroupList[11])
        {
            newBulletGroup = bulletData.FirewallUnmovingLineRightData();
        }
        else if (groupname == bulletGroupList[12])
        {
            newBulletGroup = bulletData.FirewallFlamethrowerApproachData();
        }
        else if (groupname == bulletGroupList[13])
        {
            newBulletGroup = bulletData.FirewallSurpriseCurveUpData();
        }
        else if (groupname == bulletGroupList[14])
        {
            newBulletGroup = bulletData.FirewallContinuedCurveUpData();
        }
        else if (groupname == bulletGroupList[15])
        {
            newBulletGroup = bulletData.FirewallCurveHellOneData();
        }
        else if (groupname == bulletGroupList[16])
        {
            newBulletGroup = bulletData.FirewallCurveHellTwoData();
        }
        else if (groupname == bulletGroupList[17])
        {
            newBulletGroup = bulletData.FirewallCurveHellThreeData();
        }
        else if (groupname == bulletGroupList[18])
        {
            newBulletGroup = bulletData.FirewallCurveHellFourData();
        }
        else if (groupname == bulletGroupList[19])
        {
            newBulletGroup = bulletData.FirewallCurveHellFiveData();
        }
        else if (groupname == bulletGroupList[20])
        {
            newBulletGroup = bulletData.FirewallCurveHellSixData();
        }
        else if (groupname == bulletGroupList[21])
        {
            newBulletGroup = bulletData.FirewallCurveHellSevenData();
        }
        else if (groupname == bulletGroupList[22])
        {
            newBulletGroup = bulletData.FirewallCurveHellEightData();
        }
        else if (groupname == bulletGroupList[23])
        {
            newBulletGroup = bulletData.FirewallCircleSpamOneRightData();
        }
        else if (groupname == bulletGroupList[24])
        {
            newBulletGroup = bulletData.FirewallCircleSpamOneLeftData();
        }
        else if (groupname == bulletGroupList[25])
        {
            newBulletGroup = bulletData.FirewallCircleSpamTwoRightData();
        }
        else if (groupname == bulletGroupList[26])
        {
            newBulletGroup = bulletData.FirewallCircleSpamTwoLeftData();
        }
        else if (groupname == bulletGroupList[27])
        {
            newBulletGroup = bulletData.FirewallCircleSpamThreeRightData();
        }
        else if (groupname == bulletGroupList[28])
        {
            newBulletGroup = bulletData.FirewallCircleSpamThreeLeftData();
        }
        else if (groupname == bulletGroupList[29])
        {
            newBulletGroup = bulletData.FirewallWallOfDoomRightData();
        }
        else
        {
            newBulletGroup = bulletData.EmptyBulletData();
        }
        GameObject bulletSpawner = Instantiate(bulletSpawnerPrefab, transform);
        bulletSpawner.SendMessage("StartBulletSpawning", newBulletGroup);
    }
}
