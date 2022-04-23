using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
   public GameObject item;
    public int ID;
    public string type;
    public string description;
    public GameObject ampolleta;
   

  

    public bool empty;
    public Sprite icon;

    public Transform inspection;

    public Transform slotIconGameObject;
    public InteractableOBJ interactable;

  
    


    private void Start()
    {
        slotIconGameObject = transform.GetChild(0); 
    }
    public void UpdateSlot()
    {
        slotIconGameObject.GetComponent<Image>().sprite = icon;
    }

    public void UseItem()
    {
        if(interactable.isVacio == true)
        {
            item.SetActive(false);
            slotIconGameObject.GetComponent<Image>().sprite = null;
            ampolleta.SetActive(true);
            slotIconGameObject = inspection.transform.GetChild(0);
            
        }
        

    }

    


}
