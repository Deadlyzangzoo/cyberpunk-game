using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            if (PlayerController.Instance.health < 98)
            {
                PlayerController.Instance.health += 2;
            }
            else if (PlayerController.Instance.health >= 98)
            {
                PlayerController.Instance.health = 100 ;
            }
            FirewallBossController.Instance.damage += 1 * (GameManager.Instance.bulletSpeedMultiplier / 0.5f);
            collision.gameObject.SendMessage("Deflect");
            GameObject.Destroy(gameObject);
        }
    }
}
