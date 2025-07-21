using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int deathCount;
    public string sceneOn;

    //initial values for New Game
    public GameData()
    {
        this.deathCount = 0;
        this.sceneOn = "Assets/Scenes/FirewallBoss.unity";
    }
}
