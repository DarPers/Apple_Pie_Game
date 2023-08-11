using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float moveInput;
    public Rigidbody2D rigibody;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        rigibody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rigibody.velocity = new Vector2(moveInput * speed, rigibody.velocity.y);

        switch (moveInput)
        {
            case 0:
                animator.SetBool("isPersonWalking", false);
                animator.SetBool("isPersonWalkingLeft", false);
                break;

            case > 0:
                animator.SetBool("isPersonWalking", true);
                animator.SetBool("isPersonWalkingLeft", false);
                break;

            case < 0:
                animator.SetBool("isPersonWalking", false);
                animator.SetBool("isPersonWalkingLeft", true);
                animator.SetBool("isPersonStandLeft", true);
                break;
        }
    }
}
