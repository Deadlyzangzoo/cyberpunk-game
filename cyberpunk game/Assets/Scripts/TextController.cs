using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TextController : MonoBehaviour
{
    public TMP_Text healthText;
    void Update()
    {
        healthText.text = PlayerController.Instance.health.ToString();
    }
}
