using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entra2 : MonoBehaviour
{
    public GameObject venF;
    public GameObject ven;
    public GameObject sombra;
    public GameObject luz;
    public GameObject otraluz;
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Prender());
        }
    }

    IEnumerator Prender()
    {
        yield return new WaitForSeconds(1);
        ven.SetActive(false);
        sombra.SetActive(false);
        venF.SetActive(true);
        luz.SetActive(false);
        otraluz.SetActive(false);
        gameObject.SetActive(false);
    }
}
