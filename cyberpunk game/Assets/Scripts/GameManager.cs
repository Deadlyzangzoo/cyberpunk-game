using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
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

    private void Start()
    {
        FirewallBossController.Instance.StartFight();
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
