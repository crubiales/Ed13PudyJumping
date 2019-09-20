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


    protected override void ComputeVelocity()
    {
        base.ComputeVelocity();
    }

    private void UpdateAnimatorVariables()
    {

    }

    private void Move()
    {

    }

    public void StartFalling()
    {

    }

}
