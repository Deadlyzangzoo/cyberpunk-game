using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            PlayerController.Instance.timeSinceLastAttack = 0;
            if (PlayerController.Instance.health < 99)
            {
                PlayerController.Instance.health += 1;
            }
            else if (PlayerController.Instance.health >= 99)
            {
                PlayerController.Instance.health = 100 ;
            }
            if (GameManager.Instance.currentScene.name == "FirewallBoss")
            {
                FirewallBossController.Instance.damage += 1 * (GameManager.Instance.bulletSpeedMultiplier / 0.5f);
            }
            else if (GameManager.Instance.currentScene.name == "TeamBoss")
            {
                TeamBossController.Instance.damage += 1 * (GameManager.Instance.bulletSpeedMultiplier / 0.5f);
            }
            else if (GameManager.Instance.currentScene.name == "TutorialBoss" && collision.gameObject.name != "fakeN(Clone)" && collision.gameObject.name != "fakeO(Clone)")
            {
                TextController.Instance.damage += 1 * (GameManager.Instance.bulletSpeedMultiplier / 0.5f);
            }
            
            collision.gameObject.SendMessage("Deflect");
            GameObject.Destroy(gameObject);
        }
    }
}
