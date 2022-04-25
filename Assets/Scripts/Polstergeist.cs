using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Polstergeist : MonoBehaviour
{
    public GameObject cuadro1;
    public GameObject cuadro2;
    public Locura loc;
    public Volume volume;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cuadro1.SetActive(false);
            cuadro2.SetActive(true);
            gameObject.SetActive(false);
            loc.cordura += 0.01f;
            volume.weight += 0.01f;
        }
    }
}
