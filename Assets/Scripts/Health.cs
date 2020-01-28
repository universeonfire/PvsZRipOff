using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 10;
    [SerializeField] GameObject particlePrefab;

    public void DealDamage(int damage)
    {
        health -= damage;
        if(health<= 0)
        {
            TriggerDeathVfx();
            Destroy(gameObject);
            
        }
    }

    private void TriggerDeathVfx()
    {
        if (particlePrefab)
        {
            GameObject explosion = Instantiate(particlePrefab, transform.position, Quaternion.identity) as GameObject;
            Destroy(explosion, 0.3f);
        }
    }
}
