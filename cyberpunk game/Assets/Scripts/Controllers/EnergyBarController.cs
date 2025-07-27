using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBarController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Sprite[] sprites;
    private bool dead;
    private void Start()
    {
        dead = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
        sprites = new Sprite[21]
        {
            Resources.Load<Sprite>("Sprites/energy bar 0"),
            Resources.Load<Sprite>("Sprites/energy bar 1"),
            Resources.Load<Sprite>("Sprites/energy bar 2"),
            Resources.Load<Sprite>("Sprites/energy bar 3"),
            Resources.Load<Sprite>("Sprites/energy bar 4"),
            Resources.Load<Sprite>("Sprites/energy bar 5"),
            Resources.Load<Sprite>("Sprites/energy bar 6"),
            Resources.Load<Sprite>("Sprites/energy bar 7"),
            Resources.Load<Sprite>("Sprites/energy bar 8"),
            Resources.Load<Sprite>("Sprites/energy bar 9"),
            Resources.Load<Sprite>("Sprites/energy bar 10"),
            Resources.Load<Sprite>("Sprites/energy bar 11"),
            Resources.Load<Sprite>("Sprites/energy bar 12"),
            Resources.Load<Sprite>("Sprites/energy bar 13"),
            Resources.Load<Sprite>("Sprites/energy bar 14"),
            Resources.Load<Sprite>("Sprites/energy bar 15"),
            Resources.Load<Sprite>("Sprites/energy bar 16"),
            Resources.Load<Sprite>("Sprites/energy bar 17"),
            Resources.Load<Sprite>("Sprites/energy bar 18"),
            Resources.Load<Sprite>("Sprites/energy bar 19"),
            Resources.Load<Sprite>("Sprites/energy bar 20"),
        };
    }
    void Update()
    {
        if (PlayerController.Instance.health >= 96)
        {
            spriteRenderer.sprite = sprites[20];
        }
        else if (PlayerController.Instance.health >= 91)
        {
            spriteRenderer.sprite = sprites[19];
        }
        else if (PlayerController.Instance.health >= 86)
        {
            spriteRenderer.sprite = sprites[18];
        }
        else if (PlayerController.Instance.health >= 81)
        {
            spriteRenderer.sprite = sprites[17];
        }
        else if (PlayerController.Instance.health >= 76)
        {
            spriteRenderer.sprite = sprites[16];
        }
        else if (PlayerController.Instance.health >= 71)
        {
            spriteRenderer.sprite = sprites[15];
        }
        else if (PlayerController.Instance.health >= 66)
        {
            spriteRenderer.sprite = sprites[14];
        }
        else if (PlayerController.Instance.health >= 61)
        {
            spriteRenderer.sprite = sprites[13];
        }
        else if (PlayerController.Instance.health >= 56)
        {
            spriteRenderer.sprite = sprites[12];
        }
        else if (PlayerController.Instance.health >= 51)
        {
            spriteRenderer.sprite = sprites[11];
        }
        else if (PlayerController.Instance.health >= 46)
        {
            spriteRenderer.sprite = sprites[10];
        }
        else if (PlayerController.Instance.health >= 41)
        {
            spriteRenderer.sprite = sprites[9];
        }
        else if (PlayerController.Instance.health >= 36)
        {
            spriteRenderer.sprite = sprites[8];
        }
        else if (PlayerController.Instance.health >= 31)
        {
            spriteRenderer.sprite = sprites[7];
        }
        else if (PlayerController.Instance.health >= 26)
        {
            spriteRenderer.sprite = sprites[6];
        }
        else if (PlayerController.Instance.health >= 21)
        {
            spriteRenderer.sprite = sprites[5];
        }
        else if (PlayerController.Instance.health >= 16)
        {
            spriteRenderer.sprite = sprites[4];
        }
        else if (PlayerController.Instance.health >= 11)
        {
            spriteRenderer.sprite = sprites[3];
        }
        else if (PlayerController.Instance.health >= 6)
        {
            spriteRenderer.sprite = sprites[2];
        }
        else if (PlayerController.Instance.health >= 1)
        {
            spriteRenderer.sprite = sprites[1];
        }
        else if (PlayerController.Instance.health <= 0)
        {
            spriteRenderer.sprite = sprites[0];
            if (!dead)
            {
                dead = true;
                if (GameOverController.Instance != null)
                {
                    GameOverController.Instance.SendMessage("StartGameOver");
                }
            }
        }
    }
}
