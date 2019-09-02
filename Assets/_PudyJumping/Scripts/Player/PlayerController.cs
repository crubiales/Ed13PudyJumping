using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// hereda de physiscs object para traer sus metodos y funciones
/// </summary>


public class PlayerController : PhysicObject
{
    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;

    public bool lookingRight = false;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private Vector3 move;
    
    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        animator = gameObject.GetComponent<Animator>();
    }

    #region Movement
    protected override void ComputeVelocity()
    {
        base.ComputeVelocity();
        CheckMovement();
        CheckJump();
        UpdateAnimatorVariables();
    }

    void UpdateAnimatorVariables()
    {
        animator.SetFloat("Velocity", Mathf.Abs(move.x));
    }

    void CheckMovement()
    {
        move = Vector3.zero;
        move.x = Input.GetAxis("Horizontal");
        if (Mathf.Abs(move.x) > 0.0f)
        {
            lookingRight = (move.x > 0.0f);
            spriteRenderer.flipX = !lookingRight;
        }
        targetVelocity = move * maxSpeed;
    }

    void CheckJump()
    {
        if (Input.GetButtonDown("Jump") && grounded)
        {
            isJumping = true;
            velocity.y = jumpTakeOffSpeed;
            animator.SetTrigger("StartJump");
        }
        else if (Input.GetButtonUp("Jump"))
        {
            if (velocity.y > 0)
            {
                velocity.y = velocity.y * 0.5f;
            }
        }
    }


    public override void FinishJump()
    {
        base.FinishJump();
        animator.SetTrigger("GroundedToIdle");
    }
    #endregion


    public void TakeDamage(int damageDone, int Healthleft)
    {
    }   

    private void CheckShoot()
    {
    }

    public void SetHealth(int startingHealth)
    {
    }

    private void LateUpdate()
    {
    }
}
