using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SelectionController : MonoBehaviour
{
    private InputAction moveAction;
    private string[] optionsList;
    private Vector2[] optionLocationsList;


    private void Start()
    {
        optionsList = new string[1]
        {
            "load"
        };
    }
}
