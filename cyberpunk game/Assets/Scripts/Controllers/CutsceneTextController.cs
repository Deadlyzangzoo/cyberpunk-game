using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneTextController : MonoBehaviour, IDataPersistence
{
    public static CutsceneTextController Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType(typeof(CutsceneTextController)) as CutsceneTextController;

            return _instance;
        }
        set
        {
            _instance = value;
        }
    }
    private static CutsceneTextController _instance;

    public TMP_Text anotaTextBox;
    public TMP_Text aiTextBox;
    public TMP_Text otherTextBox;
    public string[] anotaText;
    public string[] aiText;
    public string[] otherText;
    public GameObject squarePrefab;
    private GameObject instantiatedSquare;
    private SpriteRenderer squareSpriteRenderer;
    public AudioSource saviAudio;
    public AudioSource aiAudio;

    private void Start()
    {
        if (GameManager.Instance.currentScene.name == "Dialogue One")
        {
            StartCoroutine(BeginDialogueOne());
        }
        else if (GameManager.Instance.currentScene.name == "Dialogue Two")
        {
            StartCoroutine(BeginDialogueTwo());
        }
    }

    private IEnumerator BeginDialogueOne()
    {
        CoroutineWithData coroutine = new CoroutineWithData(this, SpawnText(anotaText[0], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[1], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[0], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[2], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[1], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[3], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[2], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[4], anotaTextBox));
        GameObject anotaCutscene = AnotaCutsceneController.Instance.GameObject();
        anotaCutscene.SendMessage("RunRight");
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[5], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[3], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[4], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[6], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[7], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[5], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[8], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[9], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[6], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[10], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[7], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[11], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[12], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[8], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[13], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[14], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[9], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[10], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[15], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[11], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[16], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[17], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[18], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[19], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[20], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[21], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[12], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[13], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[14], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[15], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[22], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[16], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[23], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[24], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[17], aiTextBox));
        yield return coroutine.coroutine;
        StartCoroutine(SquareFadeIn());
        coroutine = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1));
        yield return coroutine.coroutine;
        StartCoroutine(SpawnText("", aiTextBox));
        StartCoroutine(SpawnText("", anotaTextBox));
        coroutine = new CoroutineWithData(this, WaitForSecondsWithBulletSpeedUp(1));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[18], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[25], anotaTextBox));
        yield return coroutine.coroutine;
        SquareFadeOutAtStart.Instance.FadeIn();
        yield return new WaitForSeconds(1);
        DataPersistenceManager.Instance.SaveGame();
        SceneManager.LoadScene("Assets/Scenes/TeamBoss.unity");
    }
    private IEnumerator BeginDialogueTwo()
    {
        CoroutineWithData coroutine = new CoroutineWithData(this, SpawnText(otherText[0], otherTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[0], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(otherText[1], otherTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[1], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(otherText[2], otherTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[2], anotaTextBox));
        yield return coroutine.coroutine;
        GameObject anotaCutscene = AnotaCutsceneController.Instance.GameObject();
        anotaCutscene.SendMessage("RunLeft");
        coroutine = new CoroutineWithData(this, SpawnText("", otherTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[0], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[1], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[2], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[3], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[4], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[3], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[4], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[5], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[6], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(aiText[5], aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText("", aiTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(otherText[3], otherTextBox));
        yield return coroutine.coroutine;
        anotaCutscene.SendMessage("IdleLeft");
        coroutine = new CoroutineWithData(this, SpawnText(anotaText[7], anotaTextBox));
        yield return coroutine.coroutine;
        coroutine = new CoroutineWithData(this, SpawnText(otherText[4], otherTextBox));
        yield return coroutine.coroutine;
        SquareFadeOutAtStart.Instance.FadeIn();
        yield return new WaitForSeconds(1);
        DataPersistenceManager.Instance.SaveGame();
        SceneManager.LoadScene("Assets/Scenes/FinalBoss.unity");

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
    private IEnumerator SpawnText(string text, TMP_Text textBox)
    {
            textBox.text = "";
        for (int index = 0; index < text.Length; index++)
        {
            if (textBox.name == "anotaText (TMP)")
            {
                saviAudio.Play();
            }
            else if (textBox.name == "aiText (TMP)")
            {
                aiAudio.Play();
            }
            textBox.text += text[index];
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(2f);
    }

    private IEnumerator SquareFadeIn()
    {
        instantiatedSquare = Instantiate(squarePrefab, Vector3.zero, Quaternion.identity);
        DontDestroyOnLoad(instantiatedSquare);
        instantiatedSquare.transform.localScale = new Vector3(10f, 5f, 1f);
        squareSpriteRenderer = instantiatedSquare.GetComponent<SpriteRenderer>();
        Color tempColor = squareSpriteRenderer.color;
        tempColor = Color.black;
        tempColor.a = 0;
        squareSpriteRenderer.color = tempColor;
        if (squareSpriteRenderer != null)
        {
            while (squareSpriteRenderer.color.a < 1f)
            {
                tempColor = squareSpriteRenderer.color;
                tempColor.a += 0.01f;
                squareSpriteRenderer.color = tempColor;
                yield return new WaitForSeconds(0.01f);
            }
        }
        StartCoroutine(SquareFadeOut(squareSpriteRenderer));
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
        GameObject.Destroy(squareSpriteRenderer.gameObject);
    }

    public void SaveData(ref GameData data)
    {
        if (GameManager.Instance.currentScene.name == "Dialogue One")
        {
            data.sceneThatThePlayerIsOn = "Assets/Scenes/TeamBoss.unity";
        }
        else if (GameManager.Instance.currentScene.name == "Dialogue Two")
        {
            data.sceneThatThePlayerIsOn = "Assets/Scenes/FinalBoss.unity";
        }
    }
    public void LoadData(GameData data)
    {

    }
}
