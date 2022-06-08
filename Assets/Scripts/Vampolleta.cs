using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampolleta : MonoBehaviour
{
    public GameObject Objeto1;
    public GameObject Collider1;
    public GameObject CanvasPuedoDejar;
    public GameObject CanvasImageObjeto;

    [Header("Objetos Apagar")]
    public GameObject O1;
    public GameObject O2;
    public GameObject O3;
    public GameObject O4;
    public GameObject O5;







    bool isOn;
    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Objeto1.SetActive(true);
                CanvasImageObjeto.SetActive(false);
                Collider1.SetActive(true);

                Apagarobj();
                

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            isOn = true;
            CanvasPuedoDejar.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            isOn = false;
            CanvasPuedoDejar.SetActive(false);
        }
    }

    void Apagarobj()
    {
        O1.SetActive(false);
        O2.SetActive(false);
        O3.SetActive(false);
        O4.SetActive(false);
        O5.SetActive(false);




    }

}
