using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class OtraHabitacion : MonoBehaviour
{
    public GameObject LlaveImage;
    public GameObject TextoPuedeUsar;
    bool isOnDoor;
    public GameObject player;
    public PlayableDirector faded;
    public Transform SpawnearBasement;
    
    public RigidbodyON oN1;
    public RigidbodyON oN2;
    public RigidbodyON oN3;
    public RigidbodyON oN4;
    public RigidbodyON oN5;
    public RigidbodyON oN6;
    // Update is called once per frame
    void Update()
    {
        if (isOnDoor)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(Daded());
                faded.Play();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TextoPuedeUsar.SetActive(true);
            isOnDoor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TextoPuedeUsar.SetActive(false);
            isOnDoor = false;
        }
    }

    IEnumerator Daded()
    {
        yield return new WaitForSeconds(0.5f);
        oN1.enabled = true;
        oN2.enabled = true;
        oN3.enabled = true;
        oN4.enabled = true;
        oN5.enabled = true;
        oN6.enabled = true;


        
        player.transform.position = SpawnearBasement.transform.position;
        LlaveImage.SetActive(false);
    }
}
