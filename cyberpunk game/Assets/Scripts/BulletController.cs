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


    void Start()
    {
        nextBulletIsGlitched = false;
        bulletGroupList = new string[2]
        {
            "TestBullet1",
            "TestBullet2",
        };
    }


    public void StartSpawningBulletGroup(string groupname)
    {
        BulletDataStorage bulletData = new();
        BulletClass newBulletGroup = bulletData.EmptyBulletData();
        if (groupname == bulletGroupList[0])
        {
            newBulletGroup = bulletData.TestBulletOneData();
        }
        else if (groupname == bulletGroupList[1])
        {
            newBulletGroup = bulletData.TestBulletTwoData();
        }
        StartCoroutine(CreateBullets(newBulletGroup, instantiatedBullet));
    }
    private IEnumerator CreateBullets(BulletClass bulletGroup, GameObject instantiatedBullet)
    {
        transform.position = bulletGroup.startLocation;
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
                bulletDirection = bulletDirection + bulletGroup.bulletDirectionChange;
                transform.position = transform.position + bulletGroup.locationChangeBetweenBullets;
            }

            if (thisBulletIsGlitched)
            {
                instantiatedBullet = Instantiate(glitchedBulletPrefab, transform);
            }
            else
            {
                instantiatedBullet = Instantiate(bulletPrefab, transform);
            }

            IndividualBullet individualBulletObject = new();
            individualBulletObject.SetVariables(bulletGroup.pathCurved, bulletGroup.curveControlPoint, bulletGroup.curveEndPoint, bulletDirection);

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
