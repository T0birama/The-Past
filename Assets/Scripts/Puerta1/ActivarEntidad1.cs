using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarEntidad1 : MonoBehaviour
{
    public GameObject OtraEntidad;
    public GameObject timer;
    
    public GameObject empezó;
    public TimerEntidades Tiempo;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            OtraEntidad.SetActive(true);
            timer.SetActive(true);
            empezó.SetActive(true);
            Tiempo.enabled = true;
            Tiempo.tiempoAMostrarEnSegundos = Tiempo.TiempoInicial;
            Tiempo.ActualizarReloj(Tiempo.TiempoInicial);
            
        }
    }
}
