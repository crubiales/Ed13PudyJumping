using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheckFall : MonoBehaviour
{
    /// <summary>
    /// Esto es una lista de gameobjects tocados por el colisionador
    /// </summary>
    public List<GameObject> objectsTouched = new List<GameObject>();
    // referencia al script controlador de Enemy
    public Enemy enemy;


    /// <summary>
    /// Cuando collisione con un collider tipo trigger
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //si el objecto con el que colisiono es un ojbecto de la capa "Scenery" entonces 
        //puede ser que lo tenga que guardar
        if (collision.gameObject.layer == LayerMask.NameToLayer("Scenery"))
        {
            // si el GO con el que me he chocado NO existe en la lista , puedo guardarlo
            if (objectsTouched.Contains(collision.gameObject) == false)
            {
                objectsTouched.Add(collision.gameObject);
            }
        }
    }

    /// <summary>
    /// Metodo que va sacando de la lista los objetos cuando sale de ellos
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerExit2D(Collider2D collision)
    {

        if(collision.gameObject.layer == LayerMask.NameToLayer("Scenery")){

            objectsTouched.Remove(collision.gameObject);

        }
        // si nos quedamos sin objetos , tenemos que darnos la vuelta para no caernos
        if(objectsTouched.Count == 0)
        {
            //llamamos al metodo de "Enemy.cs" que le indica que debe dar la vuelta.
            enemy.StartFalling();
        }

    }

   
}
