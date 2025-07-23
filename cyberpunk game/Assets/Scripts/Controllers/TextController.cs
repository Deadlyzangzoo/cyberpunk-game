using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour, IDataPersistence
{
    public static TextController Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType(typeof(TextController)) as TextController;

            return _instance;
        }
        set
        {
            _instance = value;
        }
    }
    private static TextController _instance;


    //public TMP_Text healthText;
    public TMP_Text tutorialTextUI;
    public string[] text;
    public float damage;
    public GameObject fakeNPrefab;
    public GameObject fakeOPrefab;
    public bool fakeNInPosition;
    public bool fakeOInPosition;

    //void Update()
    //{
    //    healthText.text = PlayerController.Instance.health.ToString() + ", " + TeamBossController.Instance.damage.ToString();
    //}

    private void Start()
    {
        damage = 0;
        StartCoroutine(startTutorial());
    }

    private IEnumerator startTutorial()
    {
        BulletController bulletController = BulletController.Instance;
        CoroutineWithData coroutine = new CoroutineWithData(this, SpawnText(text[0]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[1]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[2]));
        yield return coroutine.coroutine;
        bulletController.StartSpawningBulletGroup("BulletRandomRightTutorial");
        yield return new WaitForSeconds(25);
        if (PlayerController.Instance.health == 100)
        {
            coroutine = new CoroutineWithData(this, SpawnText(text[4]));
            yield return coroutine.coroutine;
        }
        else
        {
            coroutine = new CoroutineWithData(this, SpawnText(text[3]));
            yield return coroutine.coroutine;
            PlayerController.Instance.health = 100;
        }
        coroutine = new CoroutineWithData(this, SpawnText(text[5]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[6]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[7]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[8]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[9]));
        yield return coroutine.coroutine;
        bulletController.StartSpawningBulletGroup("BulletSingleRightGlitchedTutorial");
        yield return new WaitForSeconds(9);
        while (damage <= 0)
        {
            coroutine = new CoroutineWithData(this, SpawnText(text[10]));
            yield return coroutine.coroutine;
            bulletController.StartSpawningBulletGroup("BulletSingleRightGlitchedTutorial");
            yield return new WaitForSeconds(9);
        }
        damage = 0;
        coroutine = new CoroutineWithData(this, SpawnText(text[11]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[12]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[13]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[14]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[15]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[16]));
        yield return coroutine.coroutine;
        bulletController.StartSpawningBulletGroup("BulletRandomRightGlitchedTutorial");
        coroutine = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(25f));
        yield return coroutine.coroutine;
        while (damage <= 10)
        {
            PlayerController.Instance.health = 100;
            damage = 0;
            coroutine = new CoroutineWithData(this, SpawnText(text[17]));
            yield return coroutine.coroutine;
            bulletController.StartSpawningBulletGroup("BulletRandomRightGlitchedTutorial");
            coroutine = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(25f));
            yield return coroutine.coroutine;
        }
        PlayerController.Instance.health = 100;
        coroutine = new CoroutineWithData(this, SpawnText(text[18]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[19]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[20]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[21]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[22]));
        yield return coroutine.coroutine;
        StartCoroutine(SpawnFakeNAfterFrames(43, new Vector2(-3.633f, 1.2321f)));
        StartCoroutine(SpawnFakeOAfterFrames(62, new Vector2(0.8718f, 1.23226f)));

        coroutine = new CoroutineWithData(this, SpawnText(text[23]));
        yield return coroutine.coroutine;
        while (!fakeNInPosition || !fakeOInPosition)
        {
            yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(2f);
        coroutine = new CoroutineWithData(this, SpawnText(text[24]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[25]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[26]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[27]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[28]));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(text[29]));
        yield return coroutine.coroutine;
        DataPersistenceManager.Instance.SaveGame();
        SceneManager.LoadScene("Assets/Scenes/FirewallBoss.unity");

    }
    private IEnumerator SpawnText(string text)
    {
        tutorialTextUI.text = "";
        for (int index = 0; index < text.Length; index++)
        {
            tutorialTextUI.text += text[index];
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(2);
    }
    public IEnumerator WaitForSecondsWithBulletSpeedUp(float timeWait)
    {
        float timePassed = 0f;
        while (timePassed < timeWait)
        {
            yield return new WaitForEndOfFrame();
            timePassed = timePassed + (Time.deltaTime * (GameManager.Instance.bulletSpeedMultiplier / 0.5f));
        }
        yield return true;
    }
    private IEnumerator SpawnFakeNAfterFrames(float frameWait, Vector2 location)
    {
        for (int index = 0; index < frameWait; index++)
        {
            yield return new WaitForSeconds(0.05f);
        }
        Instantiate(fakeNPrefab, location, Quaternion.identity);
    }
    private IEnumerator SpawnFakeOAfterFrames(float frameWait, Vector2 location)
    {
        for (int index = 0; index < frameWait; index++)
        {
            yield return new WaitForSeconds(0.05f);
        }
        Instantiate(fakeOPrefab, location, Quaternion.identity);
    }

    public void SaveData(ref GameData data)
    {
        if (GameManager.Instance.currentScene.name == "TutorialBoss")
        {
            data.sceneThatThePlayerIsOn = "Assets/Scenes/FirewallBoss.unity";
        }
    }
    public void LoadData(GameData data)
    {

    }
}
