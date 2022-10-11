using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoON : MonoBehaviour
{
    public GameObject ON;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ON.SetActive(true);
            StartCoroutine(apagarsonido());
        }
    }

    IEnumerator apagarsonido()
    {
        yield return new WaitForSeconds(3);
        ON.SetActive(false);
    }
}
