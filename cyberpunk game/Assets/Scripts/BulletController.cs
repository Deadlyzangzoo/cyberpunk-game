using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public string[] bulletGroupList;
    public Vector2 bulletDirection;
    public bool thisBulletIsGlitched;
    public bool nextBulletIsGlitched;
    public int bulletsRemaining;
    public int glitchedBulletsRemaining;
    public int adjacentGlitchedBulletsRemaining;
    public GameObject bulletPrefab;
    public GameObject glitchedBulletPrefab;
    private GameObject instantiatedBullet;


    void Awake()
    {
        nextBulletIsGlitched = false;
        bulletGroupList = new string[5]
        {
            "EmptyBulletData",
            "TestBullet1",
            "TestBullet2",
            "TestBulletCurve",
            "BulletShortLineLeft"
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
        else
        {
            newBulletGroup = bulletData.EmptyBulletData();
        }
            StartCoroutine(CreateBullets(newBulletGroup, instantiatedBullet));
    }
    private IEnumerator CreateBullets(BulletClass bulletGroup, GameObject instantiatedBullet)
    {
        Vector3 spawnLocation = bulletGroup.startLocation;
        bulletDirection = bulletGroup.bulletDirection;
        bulletsRemaining = bulletGroup.bulletNum;
        glitchedBulletsRemaining = bulletGroup.glitchedBulletNum;

        for (int index = 0; index <= bulletGroup.bulletNum -1 ; index++)
        {
            //deciding if this bullet should be glitched
            if (bulletGroup.glitchedBulletGuaranteed)
            {
                if (nextBulletIsGlitched)
                {
                    thisBulletIsGlitched = true;
                    adjacentGlitchedBulletsRemaining -= 1;

                    if (adjacentGlitchedBulletsRemaining == 0)
                    {
                        nextBulletIsGlitched = false;
                    }
                }

                else if (bulletsRemaining - glitchedBulletsRemaining == 0)
                {
                    thisBulletIsGlitched=true;
                }

                else
                {
                    thisBulletIsGlitched=RandomlyDecideWhetherThisBulletIsGlitched(bulletGroup);
                }
            }
            else
            {
                thisBulletIsGlitched = RandomlyDecideWhetherThisBulletIsGlitched(bulletGroup);
            }
            if (thisBulletIsGlitched)
            {
                glitchedBulletsRemaining -= 1;
                if (bulletGroup.glitchedBulletAdjacentNum != 0)
                {
                    nextBulletIsGlitched = true;
                    adjacentGlitchedBulletsRemaining -= 1;
                }
            }
            if (bulletGroup.glitchedBulletAdjacentNum != 0 && glitchedBulletsRemaining != 0 && adjacentGlitchedBulletsRemaining == 0)
            {
                adjacentGlitchedBulletsRemaining = bulletGroup.glitchedBulletAdjacentNum;
            }

            if (index != 0)
            {
                bulletDirection.x = bulletDirection.x + bulletGroup.bulletDirectionChangeX;
                bulletDirection.y = bulletDirection.y + bulletGroup.bulletDirectionChangeY;
                spawnLocation = spawnLocation + bulletGroup.locationChangeBetweenBullets;
            }

            if (thisBulletIsGlitched)
            {
                instantiatedBullet = Instantiate(glitchedBulletPrefab, spawnLocation, Quaternion.identity);
            }
            else
            {
                instantiatedBullet = Instantiate(bulletPrefab, spawnLocation, Quaternion.identity);
            }

            instantiatedBullet.SendMessage("SetPathCurved", bulletGroup.pathCurved);
            instantiatedBullet.SendMessage("SetCurveControlPointOne", bulletGroup.curveControlPointOne);
            instantiatedBullet.SendMessage("SetCurveControlPointTwo", bulletGroup.curveControlPointTwo);
            instantiatedBullet.SendMessage("SetCurveEndPoint", bulletGroup.curveEndPoint);
            instantiatedBullet.SendMessage("SetMoveDelta", bulletDirection);

            bulletsRemaining -= 1;
            yield return new WaitForSeconds(bulletGroup.timeBetweenBullets);
            thisBulletIsGlitched = false;
        }
    }
    private bool RandomlyDecideWhetherThisBulletIsGlitched(BulletClass bulletGroup)
    {
        int randNum = Random.Range(1, 100);
        if (randNum <= bulletGroup.glitchedBulletChance * 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
