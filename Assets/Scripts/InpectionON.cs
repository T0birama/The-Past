using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InpectionON : MonoBehaviour
{
    public GameObject Inspection;
    public InspectionObj inspectionObj;

    public InteractableOBJ interactableOBJ;
    public MouseLook mouseLook;
    public GameObject Bombilla;

    public Inventory inventory;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Inspection.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Item item = inspectionObj.selectedObject;
                if(item != null)
                {
                    AddItem(item.gameObject, item.id, item.type, item.description, item.icon);

                    inspectionObj.TurnOnInspection(0);

                }

                Inspection.SetActive(false);
                mouseLook.mouseSensivility=200;
                Bombilla.SetActive(false);
                mouseLook.enabled = true;
            }
        } 

        if(Inspection.activeSelf == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Inspection.SetActive(false);
                inspectionObj.TurnOffInspection();
                interactableOBJ.enabled = true;
                mouseLook.mouseSensivility = 400;
                mouseLook.enabled = true;

            }
        }
    }

    public void AddItem(GameObject itemObject , int itemID, string itemType, string itemDescription, Sprite itemIcon)
    {
        for (int i = 0; i < inventory.allSlots; i++)
        {
            if (inventory.slot[i].GetComponent<Slot>().empty)
            {
                itemObject.GetComponent<Item>().pickedUp = true;

                inventory.slot[i].GetComponent<Slot>().item = itemObject;
                inventory.slot[i].GetComponent<Slot>().ID = itemID;
                inventory.slot[i].GetComponent<Slot>().type = itemType;
                inventory.slot[i].GetComponent<Slot>().description = itemDescription;
                inventory.slot[i].GetComponent<Slot>().icon = itemIcon;

                itemObject.transform.parent = inventory.slot[i].transform;
                itemObject.SetActive(false);

                inventory.slot[i].GetComponent<Slot>().UpdateSlot(); 


                inventory.slot[i].GetComponent<Slot>().empty = false;


            }

            return;
        }
    }

    

}
