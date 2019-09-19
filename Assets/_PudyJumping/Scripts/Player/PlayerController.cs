using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// hereda de physiscs object para traer sus metodos y funciones
/// </summary>


public class PlayerController : PhysicObject
{
    public float maxSpeed;
    public float jumpTakeOffSpeed;
    private Vector3 move;
    public bool lookingRight = true;

    private SpriteRenderer spriteRenderer;



    private void Awake()
    {
        spriteRenderer = this.GetComponentInChildren<SpriteRenderer>();
    }

    #region Movement
    protected override void ComputeVelocity() // equivalente a Update
    {
        base.ComputeVelocity();
        CheckMovement();
    }

    void UpdateAnimatorVariables()
    {

    }

    void CheckMovement()
    {
        move = Vector3.zero; // reinicializamos el vector a (0,0,0)
        move.x = Input.GetAxis("Horizontal");
        // moverse en la direccion indicada a la velocidad indicada
        targetVelocity = move * maxSpeed;
        if (Mathf.Abs(move.x) > 0f)
        {
            lookingRight = move.x > 0f ? true : false;
            spriteRenderer.flipX = !lookingRight; //lo pongo a true o false dependiendo de donde miro
        }

    }

    void CheckJump()
    {

    }


    public override void FinishJump()
    {
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
