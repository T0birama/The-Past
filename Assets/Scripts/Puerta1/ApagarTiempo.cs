using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarTiempo : MonoBehaviour
{
    public GameObject tiempoui;
    public TimerEntidades timer;

    public GameObject busca;
    public GameObject sale;
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
            gameObject.SetActive(false);
            timer.ResetTimer();
            timer.enabled = false;
            tiempoui.SetActive(false);
            busca.SetActive(false);
            sale.SetActive(true);
        }
    }
}
