using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;

public class Enemy1 : MonoBehaviour
{
    public GameObject black;
    public GameObject trigger;
    public GameObject SCP173;
    public Transform player;
    public float speed = 20;
    public bool isLooking;
    public bool upOrDown = false;
    public bool isVisible = true;
    public NavMeshAgent SCP173Nav;

    public Camera virtualCamera;


    private void Start()
    {
        virtualCamera.GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = virtualCamera.WorldToViewportPoint(transform.position);
        if(viewPos.x > 0)
        {
            Debug.Log("estoy viendo en la derecha");
            isLooking = true;
            upOrDown = false;
            SCP173.GetComponent<MeshRenderer>().enabled = true;
            trigger.SetActive(false);
        }
        else 
        {
            Debug.Log("No lo veo");
            upOrDown = true;
            isLooking = false;

            SCP173.GetComponent<MeshRenderer>().enabled = false;
            trigger.SetActive(true);
        }

        if (isLooking == false)
        {
            StartCoroutine(movimientoEnemy());
        }
        else
        {
            SCP173Nav.SetDestination(SCP173.transform.position);
            trigger.SetActive(false);
            StopAllCoroutines();
        }
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    }
   

    IEnumerator movimientoEnemy()
    {
        yield return new WaitForSeconds(0.5f);
        SCP173Nav.SetDestination(player.position);
        SCP173.transform.LookAt(player.position);
        trigger.SetActive(true);
        StartCoroutine(ParaMovimiento());
    }

    IEnumerator ParaMovimiento()
    {
        yield return new WaitForSeconds(0.5f);
        SCP173Nav.SetDestination(SCP173.transform.position);
        trigger.SetActive(false);
        StartCoroutine(movimientoEnemy());

    }

    private void OnBecameVisible()
    {
        isVisible = true;
        if (upOrDown == false)
        {
            Debug.Log("Lo estoy viendoo");
            isLooking = true;
        }
    }
    private void OnBecameInvisible()
    {
        Debug.Log("NO Lo veoo");
        isVisible = false;
        isLooking = false;
    }






}
