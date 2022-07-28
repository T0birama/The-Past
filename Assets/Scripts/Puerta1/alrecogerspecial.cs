using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alrecogerspecial : MonoBehaviour
{
    public GameObject luzRoja;
    public GameObject LuzVerde;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            luzRoja.SetActive(false);
            LuzVerde.SetActive(true);
            
        }
    }
}
