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
        bulletList = new string[4]
        {
            "BulletRandomRightBulletSpam",
            "BulletRandomTopBulletSpam",
            "BulletMiddleLRBomb",
            "BulletMiddleUDBomb",
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
        bulletController.StartSpawningBulletGroup(bulletList[2]);
        bulletController.StartSpawningBulletGroup(bulletList[3]);
    }

    private IEnumerator RandomBulletRain(BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[0]);
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(13));
        yield return cd.coroutine;
        bulletController.StartSpawningBulletGroup(bulletList[1]);

    }
}