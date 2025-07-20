using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirewallBossController : MonoBehaviour
{
    public string[] bulletList;
    private void Start()
    {
        
    }
    public void StartFight()
    {
        StartCoroutine(SpawnBullets());
    }

    private IEnumerator SpawnBullets()
    {

    }
}
