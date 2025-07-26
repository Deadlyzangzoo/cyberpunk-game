using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour, IDataPersistence
{
    public static GameOverController Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType(typeof(GameOverController)) as GameOverController;

            return _instance;
        }
        set
        {
            _instance = value;
        }
    }
    private static GameOverController _instance;

    public GameObject continueButtonPrefab;
    public GameObject giveUpButtonPrefab;
    private GameObject continueButton;
    private GameObject giveUpButton;
    private InputAction moveAction;
    private InputAction confirmAction;
    private SpriteRenderer spriteRenderer;
    private SpriteRenderer continueButtonSpriteRenderer;
    private SpriteRenderer giveUpButtonSpriteRenderer;
    private bool continueButtonSelected;
    private bool allowSelection;
    private Vector2 lastSelection;
    public int deathCount;
    public bool gameOvered;
    public AudioSource audioSource;

    private void Start()
    {
        gameOvered = false;
        continueButtonSelected = true;
        spriteRenderer = GetComponent<SpriteRenderer>();
        moveAction = InputSystem.actions.FindAction("Move");
        confirmAction = InputSystem.actions.FindAction("Attack");
    }
    public void StartGameOver()
    {
        audioSource.Play();
        gameOvered = true;
        continueButton = Instantiate(continueButtonPrefab);
        giveUpButton = Instantiate(giveUpButtonPrefab);
        continueButtonSpriteRenderer = continueButton.GetComponent<SpriteRenderer>();
        giveUpButtonSpriteRenderer = giveUpButton.GetComponent<SpriteRenderer>();
        StartCoroutine(TextFadeIn(spriteRenderer));
        StartCoroutine(TextFadeIn(continueButtonSpriteRenderer));
        StartCoroutine(TextFadeIn(giveUpButtonSpriteRenderer));
        allowSelection = true;
    }

    private IEnumerator TextFadeIn(SpriteRenderer spriteRenderer)
    {
        while (spriteRenderer.color.a < 1f)
        {
            Color tempColor = spriteRenderer.color;
            tempColor.a += 0.01f;
            spriteRenderer.color = tempColor;
            yield return new WaitForSeconds(0.01f);
        }
    }

    private void Update()
    {
        if (allowSelection)
        {
            if (moveAction.ReadValue<Vector2>().x != 0)
            {
                lastSelection = moveAction.ReadValue<Vector2>();
            }
            if (lastSelection.x < 0)
            {
                continueButtonSelected = true;
                continueButtonSpriteRenderer.color = Color.yellow;
                giveUpButtonSpriteRenderer.color = Color.white;
            }
            else if (lastSelection.x > 0)
            {
                continueButtonSelected = false;
                continueButtonSpriteRenderer.color = Color.white;
                giveUpButtonSpriteRenderer.color = Color.yellow;
            }
            if (confirmAction.WasPressedThisFrame())
            {
                if (continueButtonSelected)
                {
                    SceneManager.LoadScene(GameManager.Instance.currentScene.name);
                    GameManager.Instance.fightAllowed = true;
                    deathCount += 1;
                }
                else
                {
                    deathCount += 1;
                    DataPersistenceManager.Instance.SaveGame();
                    SceneManager.LoadScene("Assets/Scenes/Main Menu.unity");
                    GameManager.Instance.fightAllowed = true;
                }
            }
        }
    }
    public void LoadData(GameData data)
    {
        this.deathCount = data.deathCount;
    }
    public void SaveData(ref GameData data)
    {
        if (gameOvered)
        {
            data.sceneThatThePlayerIsOn = "Assets/Scenes/" + GameManager.Instance.currentScene.name + ".unity";
        }
        data.deathCount = this.deathCount;
    }
}
