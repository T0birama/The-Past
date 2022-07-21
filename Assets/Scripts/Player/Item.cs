using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Item : MonoBehaviour
{

    public GameObject ConsumibleMedicamento;
    public Locura loc;
    public GameObject TextoConsumirMedicamento;
    public bool IsOnMedi;
    public GameObject imageMedic;


    private void Update()
    {
        if (IsOnMedi)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ConsumibleMedicamento.SetActive(false);
                loc.cordura = 1f ;
                loc.volume.weight = 0f ;
                TextoConsumirMedicamento.SetActive(false);
                imageMedic.SetActive(false);
}
        }
    }


    

}
