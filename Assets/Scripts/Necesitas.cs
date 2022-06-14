using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Necesitas : MonoBehaviour
{
    bool onDoor;
    public GameObject necesitasLa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onDoor)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                necesitasLa.SetActive(true);
                StartCoroutine(apago());
                
            }
        }

       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onDoor =true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onDoor=false;
           
        }
    }

    IEnumerator apago()
    {
        yield return new WaitForSeconds(2);
        necesitasLa.SetActive(false);
    }
}
