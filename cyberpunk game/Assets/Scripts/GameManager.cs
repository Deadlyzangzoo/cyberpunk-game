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

    private void Start()
    {
        bulletSpeedMultiplier = 1f;
        StartCoroutine(FireTheTwoTestBullets());
    }
    private IEnumerator FireTheTwoTestBullets()
    {
        GameObject BulletController = GameObject.Find("BulletController");
        BulletController.SendMessage("StartSpawningBulletGroup", "TestBullet1");
        yield return new WaitForSeconds(1);
        BulletController.SendMessage("StartSpawningBulletGroup", "TestBullet2");
    }
}
