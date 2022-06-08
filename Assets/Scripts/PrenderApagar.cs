using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrenderApagar : MonoBehaviour
{
    public GameObject apagar;
    public GameObject otroCollider;
    public GameObject PantallaPrendida;

    bool isONTV;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isONTV)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PantallaPrendida.SetActive(true);
                gameObject.SetActive(false);
                apagar.SetActive(false);
                otroCollider.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            isONTV = true;
            apagar.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            isONTV = false;
            apagar.SetActive(false);
        }
    }
}
