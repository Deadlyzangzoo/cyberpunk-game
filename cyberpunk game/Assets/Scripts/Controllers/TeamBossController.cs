using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeamBossController : MonoBehaviour, IDataPersistence
{
    public static TeamBossController Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType(typeof(TeamBossController)) as TeamBossController;

            return _instance;
        }
        set
        {
            _instance = value;
        }
    }
    private static TeamBossController _instance;

    public string[] bulletList;
    public float damage;
    public GameObject squarePrefab;
    private GameObject instantiatedSquare;
    private SpriteRenderer squareSpriteRenderer;

    private void Start()
    {
        damage = 0;
        bulletList = new string[38]
        {
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
        };
        StartFight();
    }

    public void StartFight()
    {
        StartCoroutine(SpawnBullets());
    }
    public void EndFight()
    {
        StartCoroutine(EndFightCoroutine());
    }
    private IEnumerator EndFightCoroutine()
    {
        SquareFadeOutAtStart.Instance.FadeIn();
        yield return new WaitForSeconds(1);
        DataPersistenceManager.Instance.SaveGame();
        if (PlayerController.Instance.health > 0)
        {
            SceneManager.LoadScene("Assets/Scenes/Dialogue Two.unity");
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
    private IEnumerator SpawnBullets()
    {
        BulletController bulletController = BulletController.Instance;
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1));
        yield return cd.coroutine;
        Coroutine coroutine = StartCoroutine(RandomBulletRain(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(24));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        bulletController.SpawnBomb(new Vector2(0f, 0f), true, 2f);
        coroutine = StartCoroutine(BombSpam(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(9));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(CurveCenter(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(6));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(TurretSpam(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(6));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(7.99999f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController)); 
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController)); 
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController)); 
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        coroutine = StartCoroutine(TurretSpam(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        coroutine = StartCoroutine(TurretSpam(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        coroutine = StartCoroutine(RandomBulletRainSlow(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        coroutine = StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(10f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        bulletController.StartSpawningBulletGroup(bulletList[36]);
        bulletController.StartSpawningBulletGroup(bulletList[37]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(20f));
        yield return cd.coroutine;
        if (!GameManager.Instance.fightAllowed)
        {
            StopCoroutine(coroutine);
            yield break;
        }
        StartCoroutine(SpawnBullets());
    }

    private IEnumerator RandomBulletRain(BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[0]);
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(13));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[1]);

    }
    private IEnumerator BombSpam(BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[2]);
        bulletController.StartSpawningBulletGroup(bulletList[3]);
        bulletController.SpawnBomb(new Vector2(-2.5f, 0f), true, 1f);
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[4]);
        bulletController.StartSpawningBulletGroup(bulletList[5]);
        bulletController.SpawnBomb(new Vector2(2f, -1.5f), true, 0.7f);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.7f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[6]);
        bulletController.StartSpawningBulletGroup(bulletList[7]);
        bulletController.SpawnBomb(new Vector2(-1f, -0.5f), true, 0.5f);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.5f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[8]);
        bulletController.StartSpawningBulletGroup(bulletList[9]);
        bulletController.SpawnBomb(new Vector2(2f, 0.5f), false, 0.9f);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.9f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[10]);
        bulletController.StartSpawningBulletGroup(bulletList[11]);
        bulletController.SpawnBomb(new Vector2(0f, 0f), false, 2f);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[12]);
        bulletController.StartSpawningBulletGroup(bulletList[13]);
        bulletController.SpawnBomb(new Vector2(-2.5f, 0f), true, 0.6f);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.6f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[4]);
        bulletController.StartSpawningBulletGroup(bulletList[5]);
        bulletController.SpawnBomb(new Vector2(2f, -1.5f), true, 0.6f);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.6f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[6]);
        bulletController.StartSpawningBulletGroup(bulletList[7]);
        bulletController.SpawnBomb(new Vector2(2f, -0.3f), true, 0.9f);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.9f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[14]);
        bulletController.StartSpawningBulletGroup(bulletList[15]);
        bulletController.SpawnBomb(new Vector2(-1f, -0.5f), true, 0.8f);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.8f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[8]);
        bulletController.StartSpawningBulletGroup(bulletList[9]);
        bulletController.SpawnBomb(new Vector2(0f, -1f), false, 0.5f);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.5f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[16]);
        bulletController.StartSpawningBulletGroup(bulletList[17]);
        bulletController.SpawnBomb(new Vector2(-1f, -1.5f), false, 0.7f);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.7f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[18]);
        bulletController.StartSpawningBulletGroup(bulletList[19]);
        bulletController.SpawnBomb(new Vector2(2f, -1.5f), true, 0.8f);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.8f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[6]);
        bulletController.StartSpawningBulletGroup(bulletList[7]);
        bulletController.SpawnBomb(new Vector2(2f, 0.5f), false, 0.6f);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.6f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[10]);
        bulletController.StartSpawningBulletGroup(bulletList[11]);
        bulletController.SpawnBomb(new Vector2(0f, -1f), false, 0.9f);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.9f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[20]);
        bulletController.StartSpawningBulletGroup(bulletList[21]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.5f));
        yield return cd.coroutine;
    }
    private IEnumerator CurveCenter(BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[22]);
        bulletController.StartSpawningBulletGroup(bulletList[23]);
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1));
        yield return cd.coroutine;
    }
    private IEnumerator TurretSpam(BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[24]);
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.5f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[25]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.5f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[26]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[27]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.5f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[28]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.5f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[29]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[30]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.5f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[31]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.5f));
        yield return cd.coroutine;
    }
    private IEnumerator SpawnSpinnyBall(BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[32]);
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1.99999f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[33]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1.99999f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[34]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1.99999f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[35]);
    }
    private IEnumerator RandomBulletRainSlow(BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[36]);
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(19));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[37]);

    }

    public void SaveData(ref GameData data)
    {
        if (GameManager.Instance.currentScene.name == "TeamBoss" && PlayerController.Instance.health > 0)
        {
            data.sceneThatThePlayerIsOn = "Assets/Scenes/Dialogue Two.unity";
        }
    }
    public void LoadData(GameData data)
    {

    }
}