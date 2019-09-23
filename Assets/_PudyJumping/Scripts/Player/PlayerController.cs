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

    public Animator animator;



    private void Awake()
    {
        spriteRenderer = this.GetComponentInChildren<SpriteRenderer>();
        // el animator lo pasamos arrastrando en unity
    }

    #region Movement
    protected override void ComputeVelocity() // equivalente a Update
    {
        base.ComputeVelocity();
        CheckMovement();
        CheckJump();
    }

    void UpdateAnimatorVariables()
    {

    }

    void CheckMovement()
    {
        move = Vector3.zero; // reinicializamos el vector a (0,0,0)
        move.x = Input.GetAxis("Horizontal");
        // moverse en la direccion indicada a la velocidad indicada

        animator.SetFloat("Velocity", Mathf.Abs(move.x));
        targetVelocity = move * maxSpeed;
        if (Mathf.Abs(move.x) > 0f)
        {
            lookingRight = move.x > 0f ? true : false;
            spriteRenderer.flipX = !lookingRight; //lo pongo a true o false dependiendo de donde miro
        }

    }

    void CheckJump()
    {
        
        // comprobacion de se ha pulsaod jump y si esta en el suelo
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
        Debug.Log($"El Jugador Ha recibido {damageDone} puntos de daño");
        // llama a la instancia (SINGLETON ) de player UI y actualiza la vida
        PlayerUI.Instance.UpdateHealth(Healthleft);


    }

    private void CheckShoot()
    {
    }

    public void SetHealth(int startingHealth)
    {
        PlayerUI.Instance.UpdateHealth(startingHealth);
    }

    private void LateUpdate()
    {
    }
}
