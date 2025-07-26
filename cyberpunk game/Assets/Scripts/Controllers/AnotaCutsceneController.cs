using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotaCutsceneController : MonoBehaviour
{
    public static AnotaCutsceneController Instance { get; private set; }
    public Animator animator;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void IdleLeft()
    {
        animator.SetBool("moving", false);
        animator.SetBool("flipped", false);
    }
    public void IdleRight()
    {
        animator.SetBool("moving", false);
        animator.SetBool("flipped", true);
    }
    public void RunLeft()
    {
        animator.SetBool("moving", true);
        animator.SetBool("flipped", false);
    }
    public void RunRight()
    {
        animator.SetBool("moving", true);
        animator.SetBool("flipped", true);
    }
}
