using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class DamageDone : UnityEvent<Damageable> { }

public class Damager : MonoBehaviour
{
    public int damageDone;

    public Collider2D damageTrigger;

    public List<string> listDamageTags;

    public DamageDone DamageDoneEvent;

    public void PerformDamage(Damageable damageable)
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    }
}
