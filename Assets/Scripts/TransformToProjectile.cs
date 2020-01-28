using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformToProjectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 1f;
    [SerializeField] int damage = 10;

    void Update()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var health = collision.GetComponent<Health>();
        var attacker = collision.GetComponent<Attacker>();
        if(health && attacker)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
