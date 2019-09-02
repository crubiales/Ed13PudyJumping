using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : PhysicObject
{
    public float maxSpeed = 2;

    private Vector3 move;

    private bool lookingRight = false;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    private void Awake()
    {
        spriteRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();
        animator = gameObject.GetComponentInChildren<Animator>();
    }


    protected override void ComputeVelocity()
    {
        base.ComputeVelocity();
        Move();
        UpdateAnimatorVariables();
    }

    private void UpdateAnimatorVariables()
    {
        animator.SetFloat("Velocity", Mathf.Abs(move.x));
    }

    private void Move()
    {
        if (lookingRight == true)
        {
            move.x = 1;
        }
        else
        {
            move.x = -1;
        }

        if (Mathf.Abs(move.x) > 0.0f)
        {
            lookingRight = (move.x > 0.01f);
            spriteRenderer.flipX = lookingRight;
        }
        targetVelocity = move * maxSpeed;

    }

    public void StartFalling()
    {
        lookingRight = !lookingRight;
    }

}
