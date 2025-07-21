using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameOverController : MonoBehaviour
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
    private SpriteRenderer spriteRenderer;
    private SpriteRenderer continueButtonSpriteRenderer;
    private SpriteRenderer giveUpButtonSpriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void StartGameOver()
    {
        continueButton = Instantiate(continueButtonPrefab);
        giveUpButton = Instantiate(giveUpButtonPrefab);
        continueButtonSpriteRenderer = continueButton.GetComponent<SpriteRenderer>();
        giveUpButtonSpriteRenderer = giveUpButton.GetComponent<SpriteRenderer>();
        StartCoroutine(TextFadeIn(spriteRenderer));
        StartCoroutine(TextFadeIn(continueButtonSpriteRenderer));
        StartCoroutine(TextFadeIn(giveUpButtonSpriteRenderer));
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
}
