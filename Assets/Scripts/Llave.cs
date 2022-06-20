using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    public GameObject TextoPuedoAgarrar;
    public GameObject LlaveImage;
    public GameObject llave;
    public GameObject PuertaCollider;
    public GameObject ColliderNecesitasLlave;
    public Inventory inventory;

    public bool isLlave;
  

    // Update is called once per frame
    void Update()
    {
        if(isLlave == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                llave.SetActive(false);
                LlaveImage.SetActive(true);
                TextoPuedoAgarrar.SetActive(false);
                PuertaCollider.SetActive(true);
                ColliderNecesitasLlave.SetActive(false);
                inventory.TimelineApagando.Play();

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isLlave = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isLlave = false;
        }
    }


}
