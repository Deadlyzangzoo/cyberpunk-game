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
    public GameObject swingPrefab;
    private InputAction moveAction;
    private InputAction swingAction;
    private BoxCollider2D boxCollider;
    private Rigidbody2D rigidBody;
    private Vector2 moveDelta;
    private Vector2 lastDirection;
    public int health;

    private void Start()
    {
        health = 100;
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        moveAction = InputSystem.actions.FindAction("Move");
        swingAction = InputSystem.actions.FindAction("Attack");
        lastDirection = new Vector3(0, 1, 0);
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

    private void Update()
    {

        if (swingAction.WasPressedThisFrame() && transform.childCount==0)
        {
            Vector3 locationToSpawnSwing = transform.position;
            int rotationAngle = 0;
            //right
            if (lastDirection.x>0 && lastDirection.y == 0)
            {
                locationToSpawnSwing.x += 0.1f;
                rotationAngle = -90;
            }
            //left
            else if (lastDirection.x < 0 && lastDirection.y == 0)
            {
                locationToSpawnSwing.x -= 0.1f;
                rotationAngle = 90;
            }
            //up
            else if (lastDirection.x == 0 && lastDirection.y > 0)
            {
                locationToSpawnSwing.y += 0.1f;
            }
            //down
            else if (lastDirection.x == 0 && lastDirection.y < 0)
            {
                locationToSpawnSwing.y -= 0.1f;
                rotationAngle = 180;
            }
            //upright
            if (lastDirection.x > 0 && lastDirection.y > 0)
            {
                locationToSpawnSwing.x += 0.071f;
                locationToSpawnSwing.y += 0.071f;
                rotationAngle = -45;
            }
            //downright
            if (lastDirection.x > 0 && lastDirection.y < 0)
            {
                locationToSpawnSwing.x += 0.071f;
                locationToSpawnSwing.y -= 0.071f;
                rotationAngle = -135;
            }
            //upleft
            if (lastDirection.x < 0 && lastDirection.y > 0)
            {
                locationToSpawnSwing.x -= 0.071f;
                locationToSpawnSwing.y += 0.071f;
                rotationAngle = 45;
            }
            //downleft
            if (lastDirection.x < 0 && lastDirection.y < 0)
            {
                locationToSpawnSwing.x -= 0.071f;
                locationToSpawnSwing.y -= 0.071f;
                rotationAngle = 135;
            }

            GameObject swing = Instantiate(swingPrefab, locationToSpawnSwing, transform.localRotation, transform);
            swing.transform.Rotate(0, 0, rotationAngle);
            StartCoroutine(DeleteSwingAfterSeconds(0.5f, swing));
        }
    }

    IEnumerator DeleteSwingAfterSeconds(float seconds, GameObject swing)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(swing);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7 || collision.gameObject.layer == 8)
        {
            health -= 20;
            GameObject.Destroy(collision.gameObject);
        }
        
    }
}
