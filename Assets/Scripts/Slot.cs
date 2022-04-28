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


    public bool empty;
    public Sprite icon;


    public Transform slotIconGameObject;
    public InteractableOBJ interactable;

  
    


    private void Start()
    {
        slotIconGameObject = transform.GetChild(0); 
    }
    public void UpdateSlot()
    {
        slotIconGameObject.GetComponent<Image>().sprite = icon;
        empty = false;
    }

    public void UseItem()
    {
        if(interactable.vacio != null)
        {
            interactable.vacio.transform.GetChild(0).gameObject.SetActive(true);
           RemoveItem();   
        }
    }

    public void RemoveItem()
    {
        Destroy(item);
        slotIconGameObject.GetComponent<Image>().sprite = null;
        empty = true;
    }


}
