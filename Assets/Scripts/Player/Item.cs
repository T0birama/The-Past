using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject ConsumibleMedicamento;
    
    public bool IsOnMedi;
    public GameObject imageMedic;
    
    public Inventory inventory;

    void Update()
    {
        if (IsOnMedi == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ConsumibleMedicamento.SetActive(false);
                gameObject.SetActive(false);
                imageMedic.SetActive(false); 
                
                inventory.medicamentoCount += 1;
                inventory.TimelineApagando.Play();
            }
        }     
    }
}
