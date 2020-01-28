using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab , gun;
    [SerializeField] int health = 10;
    private AttackerSpawner[] spawners;
    private AttackerSpawner myLaneSpawner;
    private Animator animator;
    

    void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
    }

    

    // Update is called once per frame
    void Update()
    {
        if (IsAttackerInLane())
        {
            animator.SetBool("Attack", true);
        }
        else
        {
            animator.SetBool("Attack", false);
        }
    }
    private void SetLaneSpawner()
    {
        spawners = FindObjectsOfType<AttackerSpawner>();
        foreach(var spawner in spawners)
        {
            //is spawner and game object (defender) in same lane?
            if (transform.position.y == Mathf.Floor(spawner.transform.position.y))
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        return myLaneSpawner.transform.childCount <= 0 ?  false : true;
    } 

    public void Fire()
    {
        
        var projectile = Instantiate(projectilePrefab, gun.transform.position, Quaternion.identity);
        
    }
}
