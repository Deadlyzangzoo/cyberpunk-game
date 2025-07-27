using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public float bulletSpeedMultiplier;
    public bool coroutineAllowed;
    public bool fightAllowed;
    public UnityEngine.SceneManagement.Scene currentScene;
    public GameObject squarePrefab;
    private GameObject instantiatedSquare;
    private SpriteRenderer squareSpriteRenderer;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            GameObject.Destroy(gameObject);
        }
    }

    

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, LoadSceneMode mode)
    {
        fightAllowed = true;
        currentScene = scene;
    }


    private void Start()
    {
        fightAllowed = true;
        coroutineAllowed = true;
        bulletSpeedMultiplier = 0.5f;
    }

    private void Update()
    {
        if (coroutineAllowed && bulletSpeedMultiplier > 0.5f)
        {
            StartCoroutine(WaitForBulletSlowDown());
            coroutineAllowed=false;
        }
        else if (bulletSpeedMultiplier < 0.5f)
        {
            bulletSpeedMultiplier = 0.5f;
        }
        if (currentScene.name == "TutorialBoss" && fightAllowed)
        {
            if (PlayerController.Instance.health <= 0)
            {
                fightAllowed = false;
            }
        }
        if (currentScene.name == "FirewallBoss" && fightAllowed)
        {
            if (PlayerController.Instance.health <= 0 || FirewallBossController.Instance.damage > 250)
            {
                fightAllowed = false;
                FirewallBossController.Instance.EndFight();
            }
        }
        else if (currentScene.name == "TeamBoss" && fightAllowed)
        {
            if (PlayerController.Instance.health <= 0 || TeamBossController.Instance.damage > 200)
            {
                fightAllowed = false;
                
                TeamBossController.Instance.EndFight();
            }
        }
    }

    private IEnumerator WaitForBulletSlowDown()
    {
        yield return new WaitForSeconds(3);
        StartCoroutine(StartBulletSlowdown());
    }
    private IEnumerator StartBulletSlowdown()
    {
        if (bulletSpeedMultiplier > 0.5f)
        {
            bulletSpeedMultiplier = bulletSpeedMultiplier - 0.1f;
            yield return new WaitForSeconds(0.5f);
            if (bulletSpeedMultiplier > 0.5f)
            {
                StartCoroutine(StartBulletSlowdown());
            }
            else
            {
                bulletSpeedMultiplier = 0.5f;
                coroutineAllowed = true;
            } 
        }
        else
        {
            bulletSpeedMultiplier = 0.5f;
            coroutineAllowed = true;
        }
        
    }
}
