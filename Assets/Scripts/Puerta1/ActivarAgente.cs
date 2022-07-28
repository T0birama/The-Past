using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.AI;

public class ActivarAgente : MonoBehaviour
{
    public NavMeshAgent agent;
    
    public Locura loc;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            agent.speed = 2;
            gameObject.SetActive(false);
            loc.cordura -= 0.1f;
            loc.volume.weight += 0.1f;
        }
    }
}
