using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    public Locura loc;
    public Transform player;
    public Transform[] moveSpots;
    private int randomSpot;
    public NavMeshAgent nav;
    public float distToPlayer = 5.0f;
    public float chaseRadius = 20f;
    public float facePlayerFactor = 20f;
    public Animator animator1;

    private float waitTime;
    public float startWaitTime = 1f;
    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
    }

    private void Awake()
    {
        
        nav.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if (distance > chaseRadius)
        {
            Patroling();
        }
        else if (distance <= chaseRadius)
        {
           //ChasePlayer();
        }
    }

    void Patroling()
    {
        nav.SetDestination(moveSpots[randomSpot].position);
        animator1.SetFloat("multi", 0.5f); 
        if (Vector3.Distance(transform.position, moveSpots[randomSpot].position) < 2.0f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);

                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }

    void ChasePlayer()
    {
        float distance = Vector3.Distance(player.position, transform.position);
        animator1.SetFloat("multi", 1f);
        if (distance <= chaseRadius && distance > distToPlayer)
        {
            nav.SetDestination(player.transform.position);

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            loc.cordura -= 0.05f * Time.deltaTime;
            loc.volume.weight += 0.05f * Time.deltaTime;
        }
    }


}
