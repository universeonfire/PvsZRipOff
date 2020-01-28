using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Attacker : MonoBehaviour
{
    private Animator animator;
    private GameObject currentTarget;
    private float movementSpeed = 0f;
    
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
        //if there is no target 
        if(!currentTarget) animator.SetBool("Attack", false);
    }

    public void SetMovementSpeed(float speed)
    {
        movementSpeed = speed;
    }
    
    public void Attack(GameObject target)
    {
        currentTarget = target;
        animator.SetBool("Attack", true);
    }

    public void StrikeCurrentTarget(int damage)
    {
        if (currentTarget)
        {
            Health health = currentTarget.GetComponent<Health>();
            if (health)
            {
                health.DealDamage(damage);
            }
        }
         
    } 
}
