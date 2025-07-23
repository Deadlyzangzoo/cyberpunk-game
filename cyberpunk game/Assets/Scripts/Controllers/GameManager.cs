using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public float bulletSpeedMultiplier;
    public bool coroutineAllowed;
    private float time;
    public bool fightAllowed;
    public UnityEngine.SceneManagement.Scene currentScene;

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
            if (PlayerController.Instance.health <= 0 || FirewallBossController.Instance.damage > 250)
            {
                fightAllowed = false;
                FirewallBossController.Instance.SendMessage("EndFight");
            }
        }
        else if (currentScene.name == "TeamBoss")
        {
            if (PlayerController.Instance.health <= 0 || TeamBossController.Instance.damage > 250)
            {
                fightAllowed = false;
                TeamBossController.Instance.SendMessage("EndFight");
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
