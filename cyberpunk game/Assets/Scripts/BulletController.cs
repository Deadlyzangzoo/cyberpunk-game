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
        bulletGroupList = new string[8]
        {
            "EmptyBulletData",
            "TestBullet1",
            "TestBullet2",
            "TestBulletCurve",
            "BulletShortLineLeft",
            "BulletShortLineRight",
            "BulletShortLineTop",
            "BulletShortLineBottom"
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
            newBulletGroup = bulletData.BulletShortLineLeftData();
        }
        else if (groupname == bulletGroupList[5])
        {
            newBulletGroup = bulletData.BulletShortLineRightData();
        }
        else if (groupname == bulletGroupList[6])
        {
            newBulletGroup = bulletData.BulletShortLineTopData();
        }
        else if (groupname == bulletGroupList[7])
        {
            newBulletGroup = bulletData.BulletShortLineBottomData();
        }
        else
        {
            newBulletGroup = bulletData.EmptyBulletData();
        }
        GameObject bulletSpawner = Instantiate(bulletSpawnerPrefab, transform);
        bulletSpawner.SendMessage("StartBulletSpawning", newBulletGroup);
    }
}
