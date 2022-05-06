using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entra1 : MonoBehaviour
{
    public GameObject encender;
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
            StartCoroutine(Prender());
        }
    }

    IEnumerator Prender()
    {
        yield return new WaitForSeconds(2);
        encender.SetActive(true);
        gameObject.SetActive(false);
    }
}
