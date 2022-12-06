using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;
using UnityEngine.Playables;

public class Enemy1 : MonoBehaviour
{
    public Animator Animator1;
    public GameObject black;
    public GameObject trigger;
    public GameObject SCP173;
    public Transform player;
    public float speed = 20;
    public bool isOnCamera;
    public bool upOrDown = false;
    public bool isVisible = true;
    public NavMeshAgent SCP173Nav;
    
    public Camera virtualCamera;

    RaycastHit hit;
    float distance;
    bool playerHasLineOfSight = false;

    private void Start()
    {
        virtualCamera.GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
         Vector3 viewPos = virtualCamera.WorldToViewportPoint(transform.position);
         Renderer renderer = SCP173.GetComponent<Renderer>();

        if (renderer.isVisible)
        {
            Debug.Log("estoy viendo");
            
            upOrDown = false;
            trigger.SetActive(false);
        }
        else
        {
            Debug.Log("No lo veo");
            upOrDown = true;
            
            trigger.SetActive(true);
        }


        distance = Vector3.Distance(transform.position, player.transform.position);
        Debug.DrawRay(transform.position, (player.transform.position - transform.position).normalized * distance, Color.red);
        if (Physics.Raycast(transform.position, (player.transform.position - transform.position).normalized, out hit, distance))
        {
            if (hit.collider.CompareTag("Player"))
            {
                playerHasLineOfSight = true;
                isOnCamera = true;
            }
            else
            {
                playerHasLineOfSight = false;
                isOnCamera = false;
            }
        }

        if (playerHasLineOfSight == false || isOnCamera == false)
        {
            Animator1.SetFloat("multi", 1f);
            if (SCP173Nav.enabled)
            {
                SCP173Nav.SetDestination(player.position);
            }

            SCP173.transform.LookAt(player.position);
            trigger.SetActive(true);
            //StartCoroutine(ParaMovimiento());
        }
        else if(isOnCamera == false)
        {
            Animator1.SetFloat("multi", 1f);
            if (SCP173Nav.enabled)
            {
                SCP173Nav.SetDestination(player.position);
            }

            SCP173.transform.LookAt(player.position);
            trigger.SetActive(true);
            //StartCoroutine(ParaMovimiento());
        }
        else
        {
            Animator1.SetFloat("multi", 0f);
            if (SCP173Nav.enabled)
            {
                SCP173Nav.SetDestination(SCP173.transform.position);
            }

            trigger.SetActive(false);
            
        }

        //transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

    }


    private void OnBecameVisible()
    {
        
        isOnCamera = true;
        upOrDown = false;
        trigger.SetActive(false);
    }
    private void OnBecameInvisible()
    {
        
        upOrDown = true;
        isOnCamera = false;
        trigger.SetActive(true);
    }






}
