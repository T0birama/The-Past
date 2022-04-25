using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polstergeist : MonoBehaviour
{
    public GameObject cuadro1;
    public GameObject cuadro2;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cuadro1.SetActive(false);
            cuadro2.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
