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
        if (instantiatedSquare != null)
        {
            FadeInScene();
        }
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
    private IEnumerator SquareFadeIn(SpriteRenderer squareSpriteRenderer)
    {
        if (squareSpriteRenderer != null)
        {
            while (squareSpriteRenderer.color.a < 1f)
            {
                Color tempColor = squareSpriteRenderer.color;
                tempColor.a += 0.05f;
                squareSpriteRenderer.color = tempColor;
                yield return new WaitForSeconds(0.01f);
            }
        }
        
    }
    public void FadeOutScene()
    {
        instantiatedSquare = Instantiate(squarePrefab, Vector3.zero, Quaternion.identity);
        DontDestroyOnLoad(instantiatedSquare);
        instantiatedSquare.transform.localScale = new Vector3(10f, 5f, 1f);
        squareSpriteRenderer = instantiatedSquare.GetComponent<SpriteRenderer>();
        Color tempColor = squareSpriteRenderer.color;
        tempColor = Color.black;
        tempColor.a = 0;
        squareSpriteRenderer.color = tempColor;
        StartCoroutine(SquareFadeIn(squareSpriteRenderer));
    }
    public void FadeInScene()
    {
        instantiatedSquare.transform.localScale = new Vector3(10f, 5f, 1f);
        squareSpriteRenderer = instantiatedSquare.GetComponent<SpriteRenderer>();
        Color tempColor = squareSpriteRenderer.color;
        tempColor = Color.black;
        tempColor.a = 0;
        squareSpriteRenderer.color = tempColor;
        StartCoroutine(SquareFadeOut(squareSpriteRenderer));
    }
    private IEnumerator SquareFadeOut(SpriteRenderer squareSpriteRenderer)
    {
        while (squareSpriteRenderer.color.a > 0f && squareSpriteRenderer != null)
        {
            Color tempColor = squareSpriteRenderer.color;
            tempColor.a -= 0.01f;
            squareSpriteRenderer.color = tempColor;
            yield return new WaitForSeconds(0.01f);
        }
        GameObject.Destroy(squareSpriteRenderer.gameObject);
    }
}
