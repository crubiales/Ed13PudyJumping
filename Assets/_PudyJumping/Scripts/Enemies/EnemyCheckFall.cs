using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheckFall : MonoBehaviour
{
  public Enemy enemy;
  public bool isLeft;


  public List<GameObject> objectsTouched = new List<GameObject>();
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.gameObject.layer == LayerMask.NameToLayer("Scenery"))
    {
      if (!objectsTouched.Contains(collision.gameObject))
      {
        objectsTouched.Add(collision.gameObject);
      }      
    }
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
    if (collision.gameObject.layer == LayerMask.NameToLayer("Scenery"))
    {
      objectsTouched.Remove(collision.gameObject);
    }

    if (objectsTouched.Count == 0)
    {
      enemy.StartFalling();
    }

  }




}
