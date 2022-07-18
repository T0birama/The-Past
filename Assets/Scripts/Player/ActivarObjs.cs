using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarObjs : MonoBehaviour
{
    public bool ison;
    public GameObject Puertas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ison)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Puertas.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            ison = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            ison = false;
        }
    }
}
