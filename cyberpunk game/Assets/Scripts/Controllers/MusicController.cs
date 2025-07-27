using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource audioSource;
    private bool stoppedPlaying;

    private void Update()
    {
        if (!stoppedPlaying && !GameManager.Instance.fightAllowed)
        {
            audioSource.Stop();
            stoppedPlaying = true;
        }
    }
}
