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
    public GameObject Click;
    public float Timer = 5f;
    public MeshRenderer mr1;
    public MeshRenderer mr2;
    public BoxCollider bx;

    //public Inventory inventory;

    void Update()
    {
        if (IsOnMedi == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                
                bx.enabled = false;
                mr1.enabled = false;
                mr2.enabled = false;
                //imageMedic.SetActive(false); 
                mediMano.SetActive(true);
                Click.SetActive(true);
                StartCoroutine(click());
                
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

    IEnumerator click()
    {
        yield return new WaitForSeconds(Timer);
        Click.SetActive(false);
        gameObject.SetActive(false);
        ConsumibleMedicamento.SetActive(false);
    }
    
}
