using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    public int value = 1;



    public void TakeCoin()
    {
        //añado la moneda y me destruyo
        GameManager.Instance.AddCoins(value);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Compruebo si he chocdo con player
        if (collision.gameObject.CompareTag("Player"))
        {
            TakeCoin();
        }
        
    }
}
