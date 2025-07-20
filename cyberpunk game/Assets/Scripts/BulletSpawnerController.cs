using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnerController : MonoBehaviour
{
    public Vector2 bulletDirection;
    public bool thisBulletIsGlitched;
    public bool nextBulletIsGlitched;
    public int bulletsRemaining;
    public int glitchedBulletsRemaining;
    public int adjacentGlitchedBulletsRemaining;
    public GameObject bulletPrefab;
    public GameObject glitchedBulletPrefab;
    private GameObject instantiatedBullet;

    private void Start()
    {
        nextBulletIsGlitched = false;
    }

    void StartBulletSpawning(BulletClass newBulletGroup)
    {
        StartCoroutine(CreateBullets(newBulletGroup));
    }

    private IEnumerator CreateBullets(BulletClass bulletGroup)
    {
        Vector3 spawnLocation = bulletGroup.startLocation;
        bulletDirection = bulletGroup.bulletDirection;
        bulletsRemaining = bulletGroup.bulletNum;
        glitchedBulletsRemaining = bulletGroup.glitchedBulletNum;

        for (int index = 0; index <= bulletGroup.bulletNum - 1; index++)
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

                else if (bulletsRemaining - glitchedBulletsRemaining == 0 && glitchedBulletsRemaining != 0)
                {
                    thisBulletIsGlitched = true;
                }

                else
                {
                    thisBulletIsGlitched = RandomlyDecideWhetherThisBulletIsGlitched(bulletGroup);
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
            instantiatedBullet.SendMessage("SetTimeAlive", bulletGroup.bulletTimeAlive);

            bulletsRemaining -= 1;
            if (bulletGroup.timeBetweenBullets > 0)
            {
                CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(bulletGroup.timeBetweenBullets));
                yield return cd.coroutine;
                while ((bool)cd.result != true)
                {
                    yield return new WaitForEndOfFrame();
                }
            }
            thisBulletIsGlitched = false;
        }
        GameObject.Destroy(gameObject);
    }
    private bool RandomlyDecideWhetherThisBulletIsGlitched(BulletClass bulletGroup)
    {
        int randNum = Random.Range(1, 100);
        if (randNum <= (bulletGroup.glitchedBulletChance * 100))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private IEnumerator WaitForSecondsWithBulletSpeedUp(float timeWait)
    {
        float timePassed = 0f;
        while (timePassed < timeWait)
        {
            yield return new WaitForEndOfFrame();
            timePassed = timePassed + (Time.deltaTime * (GameManager.Instance.bulletSpeedMultiplier / 0.5f));
        }
        yield return true;
    }
}
