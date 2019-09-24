using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{

    // Referencia del animador
    private Animator animator;
    // velocidad de vuelo
    public float speed = 3f;
    //indica si esta volando haca un lado u otro
    public bool flyingRight = true;
    // saber si ha golpeado ya la bola
    public bool hit;


    private void Start()
    {
        animator = this.GetComponent<Animator>();
        hit = false;
    }
    /// <summary>
    /// Se utiliza para hacer transaldos antes de las fisicas
    /// </summary>
    private void FixedUpdate()
    {
        int direccion = (flyingRight?1:-1);
       
        if (!hit)
        {
            this.transform.Translate(new Vector3(speed * Time.deltaTime *direccion , 0, 0));
        }
    }

    public void DamageDone(Damageable damageEnemy)
    {
        hit = true;
        animator.SetTrigger("Hit");
    }

    public void DestroyBall()
    {
        Destroy(this.gameObject);
    }
}
