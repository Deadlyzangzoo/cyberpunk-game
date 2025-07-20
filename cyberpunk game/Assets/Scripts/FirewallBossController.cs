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
        bulletList = new string[9]
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

    //lasts 7.5s
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
}
