using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OtraHabitacion : MonoBehaviour
{
    public GameObject LlaveImage;
    public GameObject TextoPuedeUsar;
    bool isOnDoor;
   
    // Update is called once per frame
    void Update()
    {
        if (isOnDoor)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                LlaveImage.SetActive(false);
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
}
