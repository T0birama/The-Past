using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy1 : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent Enemigo;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Enemigo.destination = Player.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemymira"))
        {
            Enemigo.speed = 0;
        }
        if (other.CompareTag("Player"))
        {
            Debug.Log("Derrota");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("enemymira"))
        {
            Enemigo.speed = 0.6f * Time.deltaTime;
        }
        
    }


}
