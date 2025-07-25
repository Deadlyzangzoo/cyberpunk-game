using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SelectionController : MonoBehaviour, IDataPersistence
{
    private InputAction moveAction;
    private InputAction confirmAction;
    private string[] optionsList;
    private int selectedOption;
    private float selectionDirection;
    private string sceneToLoad;
    public GameObject loadGameButton;
    private SpriteRenderer loadSpriteRenderer;
    public GameObject newGameButton;
    private SpriteRenderer newSpriteRenderer;
    public GameObject quitGameButton;
    private SpriteRenderer quitSpriteRenderer;


    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        confirmAction = InputSystem.actions.FindAction("Attack");
        optionsList = new string[3]
        {
            "load",
            "new",
            "quit"
        };
        loadSpriteRenderer = loadGameButton.GetComponent<SpriteRenderer>();
        newSpriteRenderer = newGameButton.GetComponent<SpriteRenderer>();
        quitSpriteRenderer = quitGameButton.GetComponent<SpriteRenderer>();
        selectedOption = 0;
    }

    private void Update()
    {
        selectionDirection = moveAction.ReadValue<Vector2>().y;
        if (selectionDirection > 0 && selectedOption > 0 && moveAction.WasPressedThisFrame())
        {
            selectedOption -= 1;
        }
        else if (selectionDirection < 0 && selectedOption < (optionsList.Length - 1) && moveAction.WasPressedThisFrame())
        {
            selectedOption += 1;
        }
        else if (selectionDirection > 0 && selectedOption == 0 && moveAction.WasPressedThisFrame())
        {
            selectedOption = optionsList.Length - 1;
        }
        else if (selectionDirection < 0 && selectedOption == (optionsList.Length - 1) && moveAction.WasPressedThisFrame())
        {
            selectedOption = 0;
        }
        if (selectedOption == 0)
        {
            loadSpriteRenderer.color = Color.yellow;
            newSpriteRenderer.color = Color.white;
            quitSpriteRenderer.color = Color.white;
        }
        else if (selectedOption == 1)
        {
            loadSpriteRenderer.color = Color.white;
            newSpriteRenderer.color = Color.yellow;
            quitSpriteRenderer.color = Color.white;
        }
        else if (selectedOption == 2)
        {
            loadSpriteRenderer.color = Color.white;
            newSpriteRenderer.color = Color.white;
            quitSpriteRenderer.color = Color.yellow;
        }
        if (confirmAction.WasPressedThisFrame())
        {
            if (selectedOption == 0)
            {
                DataPersistenceManager.Instance.LoadGame();
                SceneManager.LoadScene(sceneToLoad);
            }
            else if (selectedOption == 1)
            {
                DataPersistenceManager.Instance.NewGame();
                DataPersistenceManager.Instance.LoadGame();
                SceneManager.LoadScene(sceneToLoad);
            }
            else if (selectedOption == 2)
            {
                Application.Quit();
            }
        }
    }
    public void SaveData(ref GameData data)
    {
    }
    public void LoadData(GameData data)
    {
        sceneToLoad = data.sceneThatThePlayerIsOn;
    }
}
