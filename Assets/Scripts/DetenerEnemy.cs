using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetenerEnemy : MonoBehaviour
{
    public Collider Mira;
    public Enemy1 enemy;
    private void OnTriggerEnter(Collider Mira)
    { 
        enemy.isLooking = true;
        enemy.upOrDown = false;
        enemy.SCP173.GetComponent<MeshRenderer>().enabled = true;
        enemy.trigger.SetActive(false);
    }

    private void OnTriggerExit(Collider Mira)
    {
        enemy.upOrDown = true;
        enemy.isLooking = false;
        
        enemy.SCP173.GetComponent<MeshRenderer>().enabled = false;
        enemy.trigger.SetActive(true);
    }

    
}
