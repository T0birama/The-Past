using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject ConsumibleMedicamento;
    public Locura loc;
    //public float medicamentoCount;
    public bool IsOnMedi;
    //public GameObject imageMedic;
    public GameObject mediMano;
    
    
    //public Inventory inventory;

    void Update()
    {
        if (IsOnMedi == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                ConsumibleMedicamento.SetActive(false);
                gameObject.SetActive(false);
                //imageMedic.SetActive(false); 
                mediMano.SetActive(true);
                
                //inventory.medicamentoCount += 1;
                //inventory.TimelineApagando.Play();
            }
        }     
    }

    public void recuperarCordura()
    {
        loc.cordura = 1f;
        loc.volume.weight = 0f;
        
    }
}
