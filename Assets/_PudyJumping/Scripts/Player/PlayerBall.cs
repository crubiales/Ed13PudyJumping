using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{


    private Animator animator;



    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }


    private void FixedUpdate()
    {
    }

    public void DamageDone(Damageable damageEnemy)
    {
        animator.SetTrigger("Hit");
    }

    public void DestroyBall()
    {
        Destroy(gameObject);
    }
}
