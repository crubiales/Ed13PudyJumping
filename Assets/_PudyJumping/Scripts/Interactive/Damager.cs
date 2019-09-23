using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



/// <summary>
///Stcirpt que se encarga de hacer daño a otra entidad que tenga Damageable
/// </summary>
public class Damager : MonoBehaviour
{
    //Cantidad de daño que va ha hacer a al damageable
    public int damageDone;
    //referencia al trigger de colision de daño
    // se usa para saber con que trigger he chocado
    public Collider2D damageTrigger;

    /// <summary>
    /// Sirve para hacer daño al damageable
    /// </summary>
    /// <param name="damageable"></param>
    public void PerformDamage(Damageable damageable)
    {
        damageable.TakeDamage(this);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // si el otro objeto esta tocando mi trigger sigo
        if (damageTrigger.IsTouching(collision))
        {
            Damageable collisionDamageable;
            collisionDamageable = collision.gameObject.GetComponent<Damageable>();
            if(collisionDamageable != null)
            {
                Debug.Log($"La entidad {gameObject.name} ha realizado daño a {collision.gameObject.name}");

                //llamada al metodo que hace daño a damageable
                PerformDamage(collisionDamageable);
            }

        }




    }
}
