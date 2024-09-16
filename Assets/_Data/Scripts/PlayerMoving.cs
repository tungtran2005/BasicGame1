using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : TungMonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer rot;
    public bool OnGound = false;

    public float speed = 3.5f;
    public float jumpSpeed = 15f;

    private Vector2 toRight = new Vector2(1, 0);
    private Vector2 toLeft = new Vector2(-1, 0);

    public Animator playerAnimator;
    private string currentAnimation = "";
    protected override void LoadComponent()
    {
        base.LoadComponent();
        rb = GetComponent<Rigidbody2D>();
        rot = GetComponent<SpriteRenderer>();
        playerAnimator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKey("d"))
        {
            PlayerMove(toRight);
            PlayerRotation(true);
        }
        else if (Input.GetKey("a"))
        {
            PlayerMove(toLeft);
            PlayerRotation(false);
        }
        else
        {
            AnimationStop();
        }
        if (Input.GetKeyDown("space") == true && OnGound == true)
        {
            rb.AddForce(new Vector2(0, 1) * jumpSpeed, ForceMode2D.Impulse);
            StartCoroutine(AnimationJump());
        }
    }
    void PlayerMove(Vector2 moveVector)
    {
        Vector2 newMoveVector = new Vector2(moveVector.x * speed, rb.velocity.y);
        rb.velocity = newMoveVector;
        if (OnGound == true)
        {
            PlayingAnimation("PlayerWalk");
        }
    }
    void PlayerRotation(bool boolRot)
    {
        rot.flipX = boolRot;
    }
    void AnimationStop()
    {
        if (OnGound == true)
        {
            PlayingAnimation("PlayerIdle");
        }
    }
    IEnumerator AnimationJump()
    {
        yield return new WaitForSeconds(0.1f);
        PlayingAnimation("PlayerJump");
    }
    void PlayingAnimation(string animationName)
    {
        if(animationName != currentAnimation)
        {
            currentAnimation = animationName;
            playerAnimator.Play(currentAnimation);
            Debug.Log("playing animation : " + currentAnimation);
        }
        
    }
}
