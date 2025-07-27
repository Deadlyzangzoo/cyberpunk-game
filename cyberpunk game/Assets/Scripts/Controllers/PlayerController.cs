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
    public float movementSpeed;
    public float timeSinceLastAttack;
    public Animator playerAnimator;
    public AudioSource audioSource;
    public AudioSource swingAudio;
    private void Start()
    {
        swingCooldownTime = 0.5f;
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
            playerAnimator.SetBool("moving", true);
            lastDirection = moveDelta;
        }
        else
        {
            playerAnimator.SetBool("moving",false);

        }
            rigidBody.MovePosition(rigidBody.position + moveDelta * Time.deltaTime * movementSpeed);
        if (lastDirection.x < 0)
        {
            playerAnimator.SetBool("flipped", false);
        }
        else if (lastDirection.x > 0)
        {
            playerAnimator.SetBool("flipped", true);
        }
    }

    private void Update()
    {
        if (timeSinceLastAttack > 3 && GameManager.Instance.fightAllowed)
        {
            timeSinceLastAttack = 0;
            health-=2;
        }
        if (swingAction.WasPressedThisFrame() && transform.childCount==0)
        {
            swingAudio.Play();
            Vector3 locationToSpawnSwing = transform.position;
            int rotationAngle = 0;
            //right
            if (lastDirection.x>0 && lastDirection.y == 0)
            {
                locationToSpawnSwing.x += 0.3f;
                rotationAngle = -180;
            }
            //left
            else if (lastDirection.x < 0 && lastDirection.y == 0)
            {
                locationToSpawnSwing.x -= 0.3f;
                rotationAngle = 0;
            }
            //up
            else if (lastDirection.x == 0 && lastDirection.y > 0)
            {
                rotationAngle = -90;
                locationToSpawnSwing.y += 0.3f;
            }
            //down
            else if (lastDirection.x == 0 && lastDirection.y < 0)
            {
                locationToSpawnSwing.y -= 0.3f;
                rotationAngle = 90;
            }
            //upright
            if (lastDirection.x > 0 && lastDirection.y > 0)
            {
                locationToSpawnSwing.x += 0.213f;
                locationToSpawnSwing.y += 0.213f;
                rotationAngle = -135;
            }
            //downright
            if (lastDirection.x > 0 && lastDirection.y < 0)
            {
                locationToSpawnSwing.x += 0.213f;
                locationToSpawnSwing.y -= 0.213f;
                rotationAngle = 135;
            }
            //upleft
            if (lastDirection.x < 0 && lastDirection.y > 0)
            {
                locationToSpawnSwing.x -= 0.213f;
                locationToSpawnSwing.y += 0.213f;
                rotationAngle = -45;
            }
            //downleft
            if (lastDirection.x < 0 && lastDirection.y < 0)
            {
                locationToSpawnSwing.x -= 0.213f;
                locationToSpawnSwing.y -= 0.213f;
                rotationAngle = 45;
            }

            GameObject swing = Instantiate(swingPrefab, locationToSpawnSwing, transform.localRotation, transform);
            playerAnimator.SetBool("swinging", true);
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
        timeSinceLastAttack += Time.deltaTime;
    }

    IEnumerator DeleteSwingAfterSeconds(float seconds, GameObject swing)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(swing);
        playerAnimator.SetBool("swinging", false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7 || collision.gameObject.layer == 8 && (collision.gameObject.name != "fakeN(Clone)" && collision.gameObject.name != "fakeO(Clone)"))
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
        audioSource.Play();
        invunerable = true;
        health -=20;
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
