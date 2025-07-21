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
    private SpriteRenderer spriteRenderer;
    private Vector2 moveDelta;
    private Vector2 lastDirection;
    public int health;
    private bool invunerable;
    private float invincibilityTime;
    private float swingCooldownTime;

    private void Start()
    {
        swingCooldownTime = 1f;
        invincibilityTime = 1.5f;
        invunerable = false;
        health = 100;
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
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
            StartCoroutine(DeleteSwingAfterSeconds(swingCooldownTime, swing));
            if (GameManager.Instance.bulletSpeedMultiplier < 1f)
            {
                GameManager.Instance.bulletSpeedMultiplier *= 1.2f;

                if (GameManager.Instance.bulletSpeedMultiplier > 1f)
                {
                    GameManager.Instance.bulletSpeedMultiplier = 1f;
                }
            }
            else
            {
                GameManager.Instance.bulletSpeedMultiplier = 1f;
            }
            
        }
    }

    IEnumerator DeleteSwingAfterSeconds(float seconds, GameObject swing)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(swing);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7 || collision.gameObject.layer == 8 && !collision.gameObject.GetComponent<IndividualBullet>().deflected)
        {
            if (!invunerable)
            {
                StartCoroutine(GotHit());
            }
            GameObject.Destroy(collision.gameObject);
        }
        
    }

    private IEnumerator GotHit()
    {
        invunerable = true;
        health -= 20;
        CoroutineWithData cd = new CoroutineWithData(this, WaitForSecondsWithData(invincibilityTime));
        StartCoroutine(FlashForInvincibility(invincibilityTime));
        yield return cd.coroutine;
        invunerable = false;
    }
    private IEnumerator WaitForSecondsWithData(float timeWait)
    {
        yield return new WaitForSeconds(timeWait);
        yield return true;
    }
    private IEnumerator FlashForInvincibility(float time)
    {
        float timePassed = 0f;
        bool alphaIncreasing = false;
        while (timePassed < time)
        {
            Color tempColour = spriteRenderer.color;
            if (tempColour.a == 1)
            {
                alphaIncreasing = false ;
            }
            else if (tempColour.a <= 0.2f)
            {
                alphaIncreasing = true;
            }
            if (alphaIncreasing)
            {
                tempColour.a += 0.01f;
            }
            else
            {
                tempColour.a -= 0.01f;
            }

            spriteRenderer.color = tempColour;
            yield return new WaitForEndOfFrame();
            timePassed += Time.deltaTime;
        }
        Color resetColour = spriteRenderer.color;
        resetColour.a = 1;
        spriteRenderer.color = resetColour;
    }
}
