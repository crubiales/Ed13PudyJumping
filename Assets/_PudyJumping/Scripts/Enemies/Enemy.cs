using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : PhysicObject
{
    //velocidad a la que se mueve el enemigo
    public float maxSpeed = 1;
    // indicador de direccion 
    public bool lookingRight = false;


    private Vector3 move;

    // Sprite Reenderer
    public SpriteRenderer spriteRenderer;
    // referencia al animador11
    public Animator animator;




    private void Awake()
    {

    }

    /// <summary>
    /// Este metodo es el equivalente al update en physics object
    /// </summary>
    protected override void ComputeVelocity()
    {
        base.ComputeVelocity();
        Move();// llamada al move en todos los frames
    }

    private void UpdateAnimatorVariables()
    {

    }

    private void Move()
    {
        move = Vector3.zero;
        // con esto el pj se movera en funcion de donde mire
        if (lookingRight == false)
        {
            move.x = -1;
        }
        else
        {
            move.x = 1;
        }
        //move.x = lookingRight == false ? 1 : -1;

        // actualiza para donde esta mirando el enemigo
        if (Mathf.Abs(move.x) > 0f)
        {
            spriteRenderer.flipX = lookingRight;
        }
        // le damos movimiento al enemy
        targetVelocity = move * maxSpeed;
        animator.SetFloat("Velocity", Mathf.Abs(move.x));
    }
    /// <summary>
    /// Da la vuelta al Enemy
    /// </summary>
    public void StartFalling()
    {
        lookingRight = !lookingRight;
        Debug.Log(this.gameObject.name + "Se da la vuelta");
    }

}
