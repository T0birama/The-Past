using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unsegundo : MonoBehaviour
{
    public GameObject timelineinicio;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(iniciotime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator iniciotime()
    {
        yield return new WaitForSeconds(0.6f);
        timelineinicio.SetActive(true);
    }
}
