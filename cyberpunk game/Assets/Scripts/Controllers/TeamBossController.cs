using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamBossController : MonoBehaviour
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
        instantiatedSquare = Instantiate(squarePrefab, Vector3.zero, Quaternion.identity);
        instantiatedSquare.transform.localScale = new Vector3(10f, 5f, 1f);
        squareSpriteRenderer = instantiatedSquare.GetComponent<SpriteRenderer>();
        Color tempColor = squareSpriteRenderer.color;
        tempColor = Color.black;
        tempColor.a = 0;
        squareSpriteRenderer.color = tempColor;
        StartCoroutine(SquareFadeIn(squareSpriteRenderer));
        if (PlayerController.Instance.health <= 0)
        {
            GameOverController.Instance.SendMessage("StartGameOver");
        }
    }

    private IEnumerator SquareFadeIn(SpriteRenderer squareSpriteRenderer)
    {
        while (squareSpriteRenderer.color.a < 1f)
        {
            Color tempColor = squareSpriteRenderer.color;
            tempColor.a += 0.01f;
            squareSpriteRenderer.color = tempColor;
            yield return new WaitForSeconds(0.01f);
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
        StartCoroutine(RandomBulletRain(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(26));
        yield return cd.coroutine;
        StartCoroutine(BombSpam(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(9));
        yield return cd.coroutine;
        StartCoroutine(CurveCenter(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(6));
        yield return cd.coroutine;
        StartCoroutine(TurretSpam(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(6));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(7.99999f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController)); 
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController)); 
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController)); 
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        StartCoroutine(TurretSpam(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        StartCoroutine(TurretSpam(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        StartCoroutine(RandomBulletRainSlow(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2.6665f));
        yield return cd.coroutine;
        StartCoroutine(SpawnSpinnyBall(bulletController));
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
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[4]);
        bulletController.StartSpawningBulletGroup(bulletList[5]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.7f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[6]);
        bulletController.StartSpawningBulletGroup(bulletList[7]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.5f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[8]);
        bulletController.StartSpawningBulletGroup(bulletList[9]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.9f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[10]);
        bulletController.StartSpawningBulletGroup(bulletList[11]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(2f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[12]);
        bulletController.StartSpawningBulletGroup(bulletList[13]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.2f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[4]);
        bulletController.StartSpawningBulletGroup(bulletList[5]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.2f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[6]);
        bulletController.StartSpawningBulletGroup(bulletList[7]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.4f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[14]);
        bulletController.StartSpawningBulletGroup(bulletList[15]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.5f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[8]);
        bulletController.StartSpawningBulletGroup(bulletList[9]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.5f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[16]);
        bulletController.StartSpawningBulletGroup(bulletList[17]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.3f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[18]);
        bulletController.StartSpawningBulletGroup(bulletList[19]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.2f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[6]);
        bulletController.StartSpawningBulletGroup(bulletList[7]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.1f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[10]);
        bulletController.StartSpawningBulletGroup(bulletList[11]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.1f));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[20]);
        bulletController.StartSpawningBulletGroup(bulletList[21]);
        cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(0.4f));
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
}