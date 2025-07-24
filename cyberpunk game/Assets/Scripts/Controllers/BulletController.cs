using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public static BulletController Instance { get; private set; }

    public string[] bulletGroupList;
    public GameObject bulletSpawnerPrefab;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        bulletGroupList = new string[79]
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
            "BulletWallOfDoomTop",
            "BulletWallOfDoomDiagonal",
            "BulletScaryWallDiagonal",
            "BulletUnmovingWallDiagonal",
            "BulletTightSpaceCurveSpamOne",
            "BulletTightSpaceCurveSpamTwo",
            "BulletTightSpaceCurveSpamThree",
            "BulletTightSpaceCurveSpamFour",
            "BulletRandomRightBulletSpam",
            "BulletRandomTopBulletSpam",
            "BulletMiddleLRBomb",
            "BulletMiddleUDBomb",
            "BulletTopLeftLRBomb",
            "BulletTopLeftUDBomb",
            "BulletBottomRightLRBomb",
            "BulletBottomRightUDBomb",
            "BulletMiddleLeftLRBomb",
            "BulletMiddleLeftUDBomb",
            "BulletTopRightLRBomb",
            "BulletTopRightUDBomb",
            "BulletTopMiddleLRBomb",
            "BulletTopMiddleUDBomb",
            "BulletMiddleRightLRBomb",
            "BulletMiddleRightUDBomb",
            "BulletBottomMiddleLRBomb",
            "BulletBottomMiddleUDBomb",
            "BulletBottomLeftLRBomb",
            "BulletBottomLeftUDBomb",
            "BulletMiddleDiagonalLRBomb",
            "BulletMiddleDiagonalUDBomb",
            "BulletLeftCurveDownWall",
            "BulletRightCurveDownWall",
            "BulletTurretBottomLeft",
            "BulletTurretBottomMiddle",
            "BulletTurretBottomRight",
            "BulletTurretTopLeft",
            "BulletTurretTopMiddle",
            "BulletTurretTopRight",
            "BulletTurretLeft",
            "BulletTurretRight",
            "BulletSpinnyBallRight",
            "BulletSpinnyBallTop",
            "BulletSpinnyBallLeft",
            "BulletSpinnyBallBottom",
            "BulletRandomRightBulletSlow",
            "BulletRandomTopBulletSlow",
            "BulletRandomRightTutorial",
            "BulletSingleRightGlitchedTutorial",
            "BulletRandomRightGlitchedTutorial",
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
        else if (groupname == bulletGroupList[30])
        {
            newBulletGroup = bulletData.FirewallWallOfDoomTopData();
        }
        else if (groupname == bulletGroupList[31])
        {
            newBulletGroup = bulletData.FirewallWallOfDoomDiagonalTopRightData();
        }
        else if (groupname == bulletGroupList[32])
        {
            newBulletGroup = bulletData.FirewallScaryWallDiagonalTopRightData();
        }
        else if (groupname == bulletGroupList[33])
        {
            newBulletGroup = bulletData.FirewallUnmovingWallDiagonalTopRightData();
        }
        else if (groupname == bulletGroupList[34])
        {
            newBulletGroup = bulletData.FirewallTightSpaceCurveSpamOneData();
        }
        else if (groupname == bulletGroupList[35])
        {
            newBulletGroup = bulletData.FirewallTightSpaceCurveSpamTwoData();
        }
        else if (groupname == bulletGroupList[36])
        {
            newBulletGroup = bulletData.FirewallTightSpaceCurveSpamThreeData();
        }
        else if (groupname == bulletGroupList[37])
        {
            newBulletGroup = bulletData.FirewallTightSpaceCurveSpamFourData();
        }
        else if (groupname == bulletGroupList[38])
        {
            newBulletGroup = bulletData.TeamRandomRightBulletSpamData();
        }
        else if (groupname == bulletGroupList[39])
        {
            newBulletGroup = bulletData.TeamRandomTopBulletSpamData();
        }
        else if (groupname == bulletGroupList[40])
        {
            newBulletGroup = bulletData.TeamBombMiddleLRData();
        }
        else if (groupname == bulletGroupList[41])
        {
            newBulletGroup = bulletData.TeamBombMiddleUDData();
        }
        else if (groupname == bulletGroupList[42])
        {
            newBulletGroup = bulletData.TeamBombTopLeftLRData();
        }
        else if (groupname == bulletGroupList[43])
        {
            newBulletGroup = bulletData.TeamBombTopLeftUDData();
        }
        else if (groupname == bulletGroupList[44])
        {
            newBulletGroup = bulletData.TeamBombBottomRightLRData();
        }
        else if (groupname == bulletGroupList[45])
        {
            newBulletGroup = bulletData.TeamBombBottomRightUDData();
        }
        else if (groupname == bulletGroupList[46])
        {
            newBulletGroup = bulletData.TeamBombMiddleLeftLRData();
        }
        else if (groupname == bulletGroupList[47])
        {
            newBulletGroup = bulletData.TeamBombMiddleLeftUDData();
        }
        else if (groupname == bulletGroupList[48])
        {
            newBulletGroup = bulletData.TeamBombTopRightLRData();
        }
        else if (groupname == bulletGroupList[49])
        {
            newBulletGroup = bulletData.TeamBombTopRightUDData();
        }
        else if (groupname == bulletGroupList[50])
        {
            newBulletGroup = bulletData.TeamBombTopMiddleLRData();
        }
        else if (groupname == bulletGroupList[51])
        {
            newBulletGroup = bulletData.TeamBombTopMiddleUDData();
        }
        else if (groupname == bulletGroupList[52])
        {
            newBulletGroup = bulletData.TeamBombMiddleRightLRData();
        }
        else if (groupname == bulletGroupList[53])
        {
            newBulletGroup = bulletData.TeamBombMiddleRightUDData();
        }
        else if (groupname == bulletGroupList[54])
        {
            newBulletGroup = bulletData.TeamBombBottomMiddleLRData();
        }
        else if (groupname == bulletGroupList[55])
        {
            newBulletGroup = bulletData.TeamBombBottomMiddleUDData();
        }
        else if (groupname == bulletGroupList[56])
        {
            newBulletGroup = bulletData.TeamBombBottomLeftLRData();
        }
        else if (groupname == bulletGroupList[57])
        {
            newBulletGroup = bulletData.TeamBombBottomLeftUDData();
        }
        else if (groupname == bulletGroupList[58])
        {
            newBulletGroup = bulletData.TeamBombMiddleDiagonalLRData();
        }
        else if (groupname == bulletGroupList[59])
        {
            newBulletGroup = bulletData.TeamBombMiddleDiagonalUDData();
        }
        else if (groupname == bulletGroupList[60])
        {
            newBulletGroup = bulletData.TeamLeftCurveDownData();
        }
        else if (groupname == bulletGroupList[61])
        {
            newBulletGroup = bulletData.TeamRightCurveDownData();
        }
        else if (groupname == bulletGroupList[62])
        {
            newBulletGroup = bulletData.TeamBottomLeftTurretData();
        }
        else if (groupname == bulletGroupList[63])
        {
            newBulletGroup = bulletData.TeamBottomMiddleTurretData();
        }
        else if (groupname == bulletGroupList[64])
        {
            newBulletGroup = bulletData.TeamBottomRightTurretData();
        }
        else if (groupname == bulletGroupList[65])
        {
            newBulletGroup = bulletData.TeamTopLeftTurretData();
        }
        else if (groupname == bulletGroupList[66])
        {
            newBulletGroup = bulletData.TeamTopMiddleTurretData();
        }
        else if (groupname == bulletGroupList[67])
        {
            newBulletGroup = bulletData.TeamTopRightTurretData();
        }
        else if (groupname == bulletGroupList[68])
        {
            newBulletGroup = bulletData.TeamLeftTurretData();
        }
        else if (groupname == bulletGroupList[69])
        {
            newBulletGroup = bulletData.TeamRightTurretData();
        }
        else if (groupname == bulletGroupList[70])
        {
            newBulletGroup = bulletData.TeamSpinnyBallRightData();
        }
        else if (groupname == bulletGroupList[71])
        {
            newBulletGroup = bulletData.TeamSpinnyBallTopData();
        }
        else if (groupname == bulletGroupList[72])
        {
            newBulletGroup = bulletData.TeamSpinnyBallLeftData();
        }
        else if (groupname == bulletGroupList[73])
        {
            newBulletGroup = bulletData.TeamSpinnyBallBottomData();
        }
        else if (groupname == bulletGroupList[74])
        {
            newBulletGroup = bulletData.TeamRandomRightBulletSlowData();
        }
        else if (groupname == bulletGroupList[75])
        {
            newBulletGroup = bulletData.TeamRandomTopBulletSlowData();
        }
        else if (groupname == bulletGroupList[76])
        {
            newBulletGroup = bulletData.TutorialRandomRightBulletData();
        }
        else if (groupname == bulletGroupList[77])
        {
            newBulletGroup = bulletData.TutorialSingleGlitchedBulletRightData();
        }
        else if (groupname == bulletGroupList[78])
        {
            newBulletGroup = bulletData.TutorialRandomRightBulletGlitchedData();
        }
        else
        {
            Debug.LogError("you set the bullet group name wrong dumbass");
            newBulletGroup = bulletData.EmptyBulletData();
        }
        GameObject bulletSpawner = Instantiate(bulletSpawnerPrefab, transform);
        bulletSpawner.SendMessage("StartBulletSpawning", newBulletGroup);
    }
    public void SpawnBomb(Vector2 location, bool plus, float time)
    {
        GameObject bulletSpawner = Instantiate(bulletSpawnerPrefab, transform);
        bulletSpawner.SendMessage("SetBombLocation", location);
        bulletSpawner.SendMessage("SetBombPlus", plus);
        bulletSpawner.SendMessage("SetBombTime", time);
        bulletSpawner.SendMessage("CreateBomb");
    }
}
