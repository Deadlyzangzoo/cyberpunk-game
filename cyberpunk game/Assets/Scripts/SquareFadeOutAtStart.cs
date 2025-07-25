using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareFadeOutAtStart : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public static SquareFadeOutAtStart Instance { get; private set; }
    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(SquareFadeOut(spriteRenderer));
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
    }
    public void FadeIn()
    {
        StartCoroutine(SquareFadeIn(spriteRenderer));
    }
    private IEnumerator SquareFadeIn(SpriteRenderer squareSpriteRenderer)
    {
        while (squareSpriteRenderer.color.a < 1f && squareSpriteRenderer != null)
        {
            Color tempColor = squareSpriteRenderer.color;
            tempColor.a += 0.01f;
            squareSpriteRenderer.color = tempColor;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
