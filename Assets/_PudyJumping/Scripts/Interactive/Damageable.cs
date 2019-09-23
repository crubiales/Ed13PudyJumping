using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



/// <summary>
/// clase que implementa y gestiona la vida de la entidad
/// </summary>
public class Damageable : MonoBehaviour
{
    //vida actual
    public int curHealth;
    //vida maxima
    public int maxHealth;

    public bool isDead = false;


    //icicializar las variables
    private void Start()
    {
        curHealth = maxHealth;

        isDead = false;

    }


    public void TakeDamage(Damager damager)
    {
        Debug.Log($"{damager.gameObject.name} me ha hecho pupa");

        curHealth -= damager.damageDone;

        if(curHealth <= 0)
        {
            Die();
        }

    }
    /// <summary>
    /// metodo para morir ( sin cicuta )
    /// </summary>
    private void Die()
    {
        Debug.Log($"{this.name} dice: ME MUERO!!!!");

        Destroy(this.gameObject);
    }
}
