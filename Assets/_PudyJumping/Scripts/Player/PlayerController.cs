using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// hereda de physiscs object para traer sus metodos y funciones
/// </summary>


public class PlayerController : PhysicObject
{

    
    private void Awake()
    {

    }

    #region Movement
    protected override void ComputeVelocity()
    {

    }

    void UpdateAnimatorVariables()
    {

    }

    void CheckMovement()
    {

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
