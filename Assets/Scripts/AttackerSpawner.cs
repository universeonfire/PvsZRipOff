using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] Attacker attackerPrefab;

    private bool spawn = true;
    private float spawnTime = 0f;


    IEnumerator Start()
    {
       while (spawn)
       {
            spawnTime = Random.Range(1f, 5f);
            yield return new WaitForSeconds(spawnTime);
            Spawner();
       }
    }
    private void Spawner()
    {
        var newAttacker = Instantiate(attackerPrefab, transform.position, Quaternion.identity) as Attacker;
        //instantiate object as child of spawner object
        newAttacker.transform.parent = transform;
    }
    
    void Update()
    {
        
    }
}
