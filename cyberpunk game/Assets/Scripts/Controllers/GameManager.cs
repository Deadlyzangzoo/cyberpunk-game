using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IDataPersistence
{
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;

            return _instance;
        }
        set
        {
            _instance = value;
        }
    }

    private static GameManager _instance;
    public float bulletSpeedMultiplier;
    public bool coroutineAllowed;
    private float time;
    public bool fightAllowed;
    public int deathCount;
    public UnityEngine.SceneManagement.Scene currentScene;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void LoadData(GameData data)
    {
        this.deathCount = data.deathCount;
    }
    public void SaveData(ref GameData data)
    {
        data.deathCount = this.deathCount;
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
        time = time + Time.deltaTime;
        //Debug.Log(time);
        Debug.Log(deathCount);
        if (coroutineAllowed && bulletSpeedMultiplier > 0.5f)
        {
            StartCoroutine(WaitForBulletSlowDown());
            coroutineAllowed=false;
        }
        else if (bulletSpeedMultiplier < 0.5f)
        {
            bulletSpeedMultiplier = 0.5f;
        }
        if (currentScene.name == "FirewallBoss")
        {
            if (PlayerController.Instance.health <= 0 || FirewallBossController.Instance.damage > 130)
            {
                fightAllowed = false;
                FirewallBossController.Instance.SendMessage("EndFight");
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
