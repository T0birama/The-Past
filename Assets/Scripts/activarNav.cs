using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarNav : MonoBehaviour
{
    public Enemy1 enemy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enemy.SCP173Nav.enabled = true;
            
        }
    }
}
