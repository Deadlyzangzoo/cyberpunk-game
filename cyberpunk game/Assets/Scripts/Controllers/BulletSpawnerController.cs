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
    public GameObject plusBombPrefab;
    public GameObject crossBombPrefab;
    private Vector2 location;
    private bool plus;
    private float time;


    public void StartBulletSpawning(BulletClass newBulletGroup)
    {
        StartCoroutine(CreateBullets(newBulletGroup));
    }


    private IEnumerator CreateBullets(BulletClass bulletGroup)
    {
        Vector3 spawnLocation = bulletGroup.startLocation;
        nextBulletIsGlitched = false;
        bulletDirection = bulletGroup.bulletDirection;
        bulletsRemaining = bulletGroup.bulletNum;
        glitchedBulletsRemaining = bulletGroup.glitchedBulletNum;
        adjacentGlitchedBulletsRemaining = bulletGroup.glitchedBulletAdjacentNum;

        for (int index = 0; index <= bulletGroup.bulletNum - 1; index++)
        {
            //deciding if this bullet should be glitched
            if (bulletGroup.glitchedBulletGuaranteed)
            {
                if (nextBulletIsGlitched)
                {
                    thisBulletIsGlitched = true;
                    

                    if (adjacentGlitchedBulletsRemaining <= 0)
                    {
                        nextBulletIsGlitched = false;
                    }
                }

                else if (bulletsRemaining - glitchedBulletsRemaining == 0 && glitchedBulletsRemaining != 0)
                {
                    thisBulletIsGlitched = true;
                }

                else if (glitchedBulletsRemaining != 0)
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
                if (adjacentGlitchedBulletsRemaining > 0)
                {
                    nextBulletIsGlitched = true;
                    adjacentGlitchedBulletsRemaining -= 1;
                }
                if (adjacentGlitchedBulletsRemaining == 0)
                {
                    nextBulletIsGlitched = false;
                }
            }

            if (index != 0)
            {
                if (bulletGroup.randomSpawnBetween == null)
                {
                    bulletDirection.x = bulletDirection.x + bulletGroup.bulletDirectionChangeX;
                    bulletDirection.y = bulletDirection.y + bulletGroup.bulletDirectionChangeY;
                    spawnLocation = spawnLocation + bulletGroup.locationChangeBetweenBullets;
                }
                else
                {
                    spawnLocation = new Vector3(Random.Range(bulletGroup.randomSpawnBetween[0].x * 100, bulletGroup.randomSpawnBetween[1].x * 100)/100, Random.Range(bulletGroup.randomSpawnBetween[0].y * 100, bulletGroup.randomSpawnBetween[1].y * 100)/100);
                }
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
            if (bulletGroup.locationChangeBetweenBullets == new Vector3(0f, 0f))
            {
                instantiatedBullet.SendMessage("SetCurveControlPointOne", bulletGroup.curveControlPointOne);
                instantiatedBullet.SendMessage("SetCurveControlPointTwo", bulletGroup.curveControlPointTwo);
                instantiatedBullet.SendMessage("SetCurveEndPoint", bulletGroup.curveEndPoint);
            }
            else
            {
                instantiatedBullet.SendMessage("SetCurveControlPointOne", bulletGroup.curveControlPointOne + spawnLocation);
                instantiatedBullet.SendMessage("SetCurveControlPointTwo", bulletGroup.curveControlPointTwo + spawnLocation);
                instantiatedBullet.SendMessage("SetCurveEndPoint", bulletGroup.curveEndPoint + spawnLocation);
            }
            instantiatedBullet.SendMessage("SetMoveDelta", bulletDirection);
            instantiatedBullet.SendMessage("SetTimeAlive", bulletGroup.bulletTimeAlive);
            instantiatedBullet.SendMessage("SetBulletSolid", bulletGroup.bulletSolid);
            instantiatedBullet.SendMessage("SetBulletGlitched", thisBulletIsGlitched);
            instantiatedBullet.SendMessage("SetBulletDontDecay", bulletGroup.dontDecay);

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

    public IEnumerator CreateBomb()
    {
        GameObject instantiatedBomb = new();
        if (plus)
        {
            instantiatedBomb = Instantiate(plusBombPrefab, location, Quaternion.identity);
        }
        else
        {
            instantiatedBomb = Instantiate(crossBombPrefab, location, Quaternion.identity);
        }
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(time));
        yield return cd.coroutine;
        GameManager.Destroy(instantiatedBomb);
        GameObject.Destroy(gameObject);
    }
    private void SetBombLocation(Vector2 locationRecieved)
    {
        location = locationRecieved;
    }
    private void SetBombPlus(bool plusRecieved)
    {
        plus = plusRecieved;
    }
    private void SetBombTime(float timeRecieved)
    {
        time = timeRecieved;
    }
}
