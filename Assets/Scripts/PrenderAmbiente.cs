using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrenderAmbiente : MonoBehaviour
{
    public GameObject ambiente;
    public AudioSource audioAmbiente;
    public AudioSource audioPuerta;

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
                audioAmbiente.mute = false;
                audioPuerta.mute = true;
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
