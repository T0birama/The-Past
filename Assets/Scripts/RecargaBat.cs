using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecargaBat : MonoBehaviour
{
    public LuzReduction lu;
    public GameObject SpotLinterna;
    public GameObject Pilas;
    public GameObject TextPuedoAPilas;
    public GameObject imageBat;

    bool isOnPilas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnPilas)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(lu.linterna.enabled == false)
                {
                    lu.linterna.enabled = true;
                }
                lu.linterna.intensity = 1772.727f;
                Pilas.SetActive(false);
                TextPuedoAPilas.SetActive(false);
                imageBat.SetActive(false);
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            isOnPilas = true;
            TextPuedoAPilas.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            isOnPilas = false;
            TextPuedoAPilas.SetActive(false);
        }
    }

}
