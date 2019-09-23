using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    // variable que indicaremos en unity para cargar el nivel que queramos
    public int NextLevelId;

    /// <summary>
    /// cuando colisione con algo se ejecuta este metodo
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {// si el que ha collisionado es player ( "por tag") entonces cargo el siguient enivel
        if (collision.gameObject.CompareTag("Player") == true)
        {
            SceneManager.LoadScene(NextLevelId);
        }
    }
    
}
