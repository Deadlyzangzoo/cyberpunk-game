using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirewallBossController : MonoBehaviour
{
    public static FirewallBossController Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType(typeof(FirewallBossController)) as FirewallBossController;

            return _instance;
        }
        set
        {
            _instance = value;
        }
    }
    private static FirewallBossController _instance;

    public string[] bulletList;

    private void Start()
    {
        bulletList = new string[34]
        {
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
        };
    }
    public void StartFight()
    {
        StartCoroutine(SpawnBullets());
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

    private IEnumerator SpawnBullets()
    {
        BulletController bulletController = BulletController.Instance;
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(SpawnAllDirectionBulletEnclosure(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(7));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(SpawnFlamethrowerTrap(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(10));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(SpawnSurpriseCurveUp(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(7));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(SpawnCurveHell(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(12));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(SpawnCircleSpam(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(8));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }

        StartCoroutine(SpawnAllDirectionBulletEnclosure(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(SpawnCurveHell(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(12));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        for (int i = 0; i < 10; i++)
        {
            bulletController.StartSpawningBulletGroup(bulletList[25]);
            cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1.8f));
            yield return cd.coroutine;
            while ((bool)cd.result != true)
            {
                yield return new WaitForEndOfFrame();
            }
        }
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2f));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        for (int i = 0; i < 5; i++)
        {
            bulletController.StartSpawningBulletGroup(bulletList[26]);
            cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(5f));
            yield return cd.coroutine;
            while ((bool)cd.result != true)
            {
                yield return new WaitForEndOfFrame();
            }
        }
        for (int i = 0; i < 5; i++)
        {
            bulletController.StartSpawningBulletGroup(bulletList[27]);
            cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(5.5f));
            yield return cd.coroutine;
            while ((bool)cd.result != true)
            {
                yield return new WaitForEndOfFrame();
            }
        }
        bulletController.StartSpawningBulletGroup(bulletList[28]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(5f));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        bulletController.StartSpawningBulletGroup(bulletList[29]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1f));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(SpawnTightSpaceCurveSpam(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(18f));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(SpawnBullets());
    }
    private IEnumerator SpawnLeftRightBulletEnclosure(BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[0]);
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(4));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        bulletController.StartSpawningBulletGroup(bulletList[1]);
    }
    private IEnumerator SpawnTopBottomBulletEnclosure(BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[2]);
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(4));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        bulletController.StartSpawningBulletGroup(bulletList[3]);
    }
    private IEnumerator SpawnAllDirectionBulletEnclosure(BulletController bulletController)
    {
        StartCoroutine(SpawnLeftRightBulletEnclosure(bulletController));
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(SpawnTopBottomBulletEnclosure(bulletController));
    }
    private IEnumerator SpawnFlamethrowerTrap(BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[4]);
        bulletController.StartSpawningBulletGroup(bulletList[5]);
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(3));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        bulletController.StartSpawningBulletGroup(bulletList[6]);
        bulletController.StartSpawningBulletGroup(bulletList[7]);
        bulletController.StartSpawningBulletGroup(bulletList[8]);
    }
    private IEnumerator SpawnSurpriseCurveUp (BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[9]);
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.2f));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        bulletController.StartSpawningBulletGroup(bulletList[10]);
    }
    private IEnumerator SpawnCurveHell (BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[11]);
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1f));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        bulletController.StartSpawningBulletGroup(bulletList[12]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1f));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        bulletController.StartSpawningBulletGroup(bulletList[13]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1f));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        bulletController.StartSpawningBulletGroup(bulletList[14]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(3.5f));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        bulletController.StartSpawningBulletGroup(bulletList[15]);
        bulletController.StartSpawningBulletGroup(bulletList[16]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1f));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        bulletController.StartSpawningBulletGroup(bulletList[17]);
        bulletController.StartSpawningBulletGroup(bulletList[18]);
    }
    private IEnumerator SpawnCircleSpam (BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[19]);
        bulletController.StartSpawningBulletGroup(bulletList[20]);
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(5f));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        bulletController.StartSpawningBulletGroup(bulletList[21]);
        bulletController.StartSpawningBulletGroup(bulletList[22]);
        bulletController.StartSpawningBulletGroup(bulletList[23]);
        bulletController.StartSpawningBulletGroup(bulletList[24]);
    }
    private IEnumerator SpawnTightSpaceCurveSpam (BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[30]);
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(3f));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        bulletController.StartSpawningBulletGroup(bulletList[31]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(4f));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        bulletController.StartSpawningBulletGroup(bulletList[32]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(4.5f));
        yield return cd.coroutine;
        while ((bool)cd.result != true)
        {
            yield return new WaitForEndOfFrame();
        }
        bulletController.StartSpawningBulletGroup(bulletList[33]);
    }
}
