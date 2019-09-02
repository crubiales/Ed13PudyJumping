using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class DamageReceived : UnityEvent<int, int> { }
[System.Serializable]
public class HealthSet : UnityEvent<int> { }

public class Damageable : MonoBehaviour
{
    public DamageReceived damageReceived;
    public HealthSet healthSet;


    private void Start()
    {
    }


    public void TakeDamage(Damager damager)
    {
    }

    private void Die()
    {
        Destroy(this.gameObject);
    }
}
