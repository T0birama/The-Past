using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iAmpolleta : MonoBehaviour
{
    public GameObject Objeto1;
    public GameObject Collider1;
    public GameObject CanvasPuedoAgarrar;
    public GameObject CanvasImageObjeto;
    
    [Header("Objetos Apagar")]
    public GameObject O1;
    public GameObject O2;


    [Header("Objetos Prender")]
    public GameObject OP1;
    



    bool isOn; 
    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Objeto1.SetActive(false);
                Collider1.SetActive(true);
                CanvasImageObjeto.SetActive(true);

                Apagarobj();
                Prenderobjs();

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOn = true;
            CanvasPuedoAgarrar.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOn = false;
            CanvasPuedoAgarrar.SetActive(false);
        }
    }

    void Apagarobj()
    {
        O1.SetActive(false);
        O1.SetActive(false);


    }

    void Prenderobjs()
    {
        OP1.SetActive(true);
        
    }
}
