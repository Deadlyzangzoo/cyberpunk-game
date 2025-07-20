using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirewallBossController : MonoBehaviour
{
    public static FirewallBossController Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType(typeof(FirewallBossController)) as FirewallBossController;

            return _instance;
        }
        set
        {
            _instance = value;
        }
    }
    private static FirewallBossController _instance;

    public string[] bulletList;
    private void Start()
    {
        bulletList = new string[9]
        {
            "BulletShortLineLeft",
            "BulletShortLineRight",
            "BulletShortLineTop",
            "BulletShortLineBottom",
            "BulletDiagonalLineLeft",
            "BulletDiagonalLineRight",
            "BulletUnmovingLineLeft",
            "BulletUnmovingLineRight",
            "BulletFlamethrowerApproach",
        };
    }
    public void StartFight()
    {
        StartCoroutine(SpawnBullets());
    }

    private IEnumerator SpawnBullets()
    {
        BulletController bulletController = BulletController.Instance;
        yield return new WaitForSeconds(1);
        StartCoroutine(SpawnAllDirectionBulletEnclosure(bulletController));
        yield return new WaitForSeconds(7);
        bulletController.StartSpawningBulletGroup(bulletList[4]);
        bulletController.StartSpawningBulletGroup(bulletList[5]);
        yield return new WaitForSeconds(3);
        bulletController.StartSpawningBulletGroup(bulletList[6]);
        bulletController.StartSpawningBulletGroup(bulletList[7]);
        bulletController.StartSpawningBulletGroup(bulletList[8]);
    }

    private IEnumerator SpawnLeftRightBulletEnclosure(BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[0]);
        yield return new WaitForSeconds(4);
        bulletController.StartSpawningBulletGroup(bulletList[1]);
    }
    private IEnumerator SpawnTopBottomBulletEnclosure(BulletController bulletController)
    {
        bulletController.StartSpawningBulletGroup(bulletList[2]);
        yield return new WaitForSeconds(4);
        bulletController.StartSpawningBulletGroup(bulletList[3]);
    }

    private IEnumerator SpawnAllDirectionBulletEnclosure(BulletController bulletController)
    {
        StartCoroutine(SpawnLeftRightBulletEnclosure(bulletController));
        yield return new WaitForSeconds(2);
        StartCoroutine(SpawnTopBottomBulletEnclosure(bulletController));
    }
}
