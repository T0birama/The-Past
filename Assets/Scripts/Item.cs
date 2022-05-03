using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Item : MonoBehaviour
{

    public GameObject ConsumibleMedicamento;
    public Locura loc;
    public Volume volume;
    public GameObject TextoConsumirMedicamento;
    bool IsOnMedi;


    private void Update()
    {
        if (IsOnMedi)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ConsumibleMedicamento.SetActive(false);
                loc.cordura -= 0.5f;
                volume.weight -= 0.5f;
                TextoConsumirMedicamento.SetActive(false);
}
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IsOnMedi = true;
            TextoConsumirMedicamento.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IsOnMedi = false;
            TextoConsumirMedicamento.SetActive(false);
        }
    }

}
