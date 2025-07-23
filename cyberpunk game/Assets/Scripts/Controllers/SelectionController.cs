using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SelectionController : MonoBehaviour
{
    private InputAction moveAction;
    private InputAction confirmAction;
    private string[] optionsList;
    private Vector2[] optionLocationsList;
    private int selectedOption;
    private float selectionDirection;


    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        confirmAction = InputSystem.actions.FindAction("Attack");
        optionsList = new string[1]
        {
            "load"
        };
        selectedOption = 0;
    }

    private void Update()
    {
        selectionDirection = moveAction.ReadValue<Vector2>().y;
        if (selectionDirection > 0 && selectedOption > 0)
        {
            selectedOption -= 1;
        }
        else if (selectionDirection < 0 && selectedOption < (optionsList.Length - 1))
        {
            selectedOption += 1;
        }
        else if (selectionDirection > 0 && selectedOption == 0)
        {
            selectedOption = optionsList.Length - 1;
        }
        else if (selectionDirection < 0 && selectedOption == (optionsList.Length - 1))
        {
            selectedOption = 0;
        }

        if (confirmAction.WasPressedThisFrame())
        {
            if (selectedOption == 0)
            {
                DataPersistenceManager.Instance.LoadGame();
            }
        }
    }
}
