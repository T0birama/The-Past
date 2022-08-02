using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrenderAmbiente : MonoBehaviour
{
    public GameObject ambiente;
    public GameObject audioAmbiente;
    public GameObject audioPuerta;

    bool isON;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isON)
        {
            if (Input.GetKey(KeyCode.E))
            {
                ambiente.SetActive(true);
                audioAmbiente.SetActive(true);
                audioPuerta.SetActive(false);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isON = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isON = false;
        }
    }
}
