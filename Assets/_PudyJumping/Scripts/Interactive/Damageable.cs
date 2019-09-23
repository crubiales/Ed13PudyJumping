using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class DamageReceived : UnityEvent<int, int> { };

[System.Serializable]
public class HealthSet : UnityEvent<int> { };

/// <summary>
/// clase que implementa y gestiona la vida de la entidad
/// </summary>
public class Damageable : MonoBehaviour
{

   //public UnityEvent eventoSimple;
   // instanciacion de los eventos health y Damage received
    public HealthSet healthSet;
    public DamageReceived damageReceived;


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

        //invocacion del evento para setear la vida
        healthSet.Invoke(curHealth);

    }

    /// <summary>
    /// metodo que llama damager cuando le quiere hacer daño a damageable
    /// </summary>
    /// <param name="damager"></param>
    public void TakeDamage(Damager damager)
    {
        Debug.Log($"{damager.gameObject.name} me ha hecho pupa");
        //resta de la vida restante
        curHealth -= damager.damageDone;
        //invocacion al UnityEvent de "he hecho daño "
        damageReceived.Invoke(damager.damageDone, curHealth);
        // si la vida esta por debajo de 0 
        if(curHealth <= 0)
        {
            Die();// doblo la servilleta , amocho , la espicho , crio malvas .....
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
