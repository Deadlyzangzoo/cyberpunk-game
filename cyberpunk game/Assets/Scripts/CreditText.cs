using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class CreditText : MonoBehaviour, IDataPersistence
{
    public static CreditText Instance { get; private set; }
    public TMP_Text text;
    private int deathCount;
    private InputAction confirm;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    private void Start()
    {
        confirm = InputSystem.actions.FindAction("Attack");
        DataPersistenceManager.Instance.LoadGame();
        text.text += "Deathcount: " + deathCount;
        DataPersistenceManager.Instance.SaveGame();

    }
    private void Update()
    {
        if (confirm.WasPressedThisFrame())
        {
            SceneManager.LoadScene("Assets/Scenes/Main Menu.unity");
        }
    }
    public void SaveData(ref GameData data)
    {
        data.sceneThatThePlayerIsOn = "Assets/Scenes/Credits.unity";
    }
    public void LoadData(GameData data)
    {
        deathCount = data.deathCount;
    }
}
