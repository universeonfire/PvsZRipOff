using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardAttack : MonoBehaviour
{
 
    private void OnTriggerEnter2D(Collider2D collision)
{
        GameObject collObject = collision.gameObject;
        GetComponent<Attacker>().Attack(collObject);

        //i am using collision matrix so i dont need this but stays as an example just in case 
        /*if (collObject.GetComponent<Defender>())
        {
            Debug.Log("def coll");
            GetComponent<Attacker>().Attack(collObject);
        }
        */
    }
   
}
