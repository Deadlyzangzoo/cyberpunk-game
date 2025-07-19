using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType(typeof(PlayerController)) as PlayerController;

            return _instance;
        }
        set
        {
            _instance = value;
        }
    }

    private static PlayerController _instance;
    private InputAction moveAction;
    private InputAction swingAction;
    private BoxCollider2D boxCollider;
    private Rigidbody2D rigidBody;
    public SpriteRenderer spriteRenderer;
    private Vector2 moveDelta;
    private Vector2 lastDirection;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        moveAction = InputSystem.actions.FindAction("Move");
        swingAction = InputSystem.actions.FindAction("Attack");
    }

    private void FixedUpdate()
    {
        moveDelta = moveAction.ReadValue<Vector2>();
        if (moveDelta.x != 0 || moveDelta.y != 0)
        {
            lastDirection = moveDelta;
        }
        rigidBody.MovePosition(rigidBody.position + moveDelta * Time.deltaTime);
    }
}
