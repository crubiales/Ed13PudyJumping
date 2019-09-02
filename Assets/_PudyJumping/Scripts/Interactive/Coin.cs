using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{

    private Animator myAnimator;
    private SpriteRenderer mySpriteRenderer;

    private void Start()
    {
        myAnimator = gameObject.GetComponentInChildren<Animator>();
        mySpriteRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();
    }

    public void TakeCoin()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
