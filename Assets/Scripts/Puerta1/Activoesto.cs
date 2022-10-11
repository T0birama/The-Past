using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activoesto : MonoBehaviour
{
    public GameObject Linterna;
    public GameObject cabezas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Linterna.activeSelf)
        {
            StartCoroutine(prender());
        }
        
    }

    IEnumerator prender()
    {
        yield return new WaitForSeconds(1);
        cabezas.SetActive(false);
    }
}
