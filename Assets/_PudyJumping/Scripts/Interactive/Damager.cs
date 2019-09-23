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
    // entidad a la que va dirigida el daño
    public string damageTag;

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
            //si el objeto con el que choco tiene el tag que busco 
            if (collision.gameObject.CompareTag(damageTag) == true)
            {
                Damageable collisionDamageable;
                collisionDamageable = collision.gameObject.GetComponent<Damageable>();
                // si contiene la variable de Damageable entonces le hago daño
                if (collisionDamageable != null)
                {
                    Debug.Log($"La entidad {gameObject.name} ha realizado daño a {collision.gameObject.name}");

                    //llamada al metodo que hace daño a damageable
                    PerformDamage(collisionDamageable);
                }
            }


        }




    }
}
