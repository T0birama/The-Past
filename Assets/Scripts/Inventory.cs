using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Inventory : MonoBehaviour
{
    private bool inventoryEnabled;
    
    public GameObject inventory;

    public int allSlots;

    private int enabledSlot;

    public GameObject[] slot;

    public GameObject slotHandler;
    public MouseLook mouseLook;
    private void Start()
    {
        
        allSlots = slotHandler.transform.childCount;

        slot = new GameObject[allSlots];

        for (int i = 0; i < allSlots; i++)
        {
            slot[i] = slotHandler.transform.GetChild(i).gameObject;

            if(slot[i].GetComponent<Slot>().item == null)
            {
                slot[i].GetComponent<Slot>().empty = true;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inventoryEnabled=!inventoryEnabled;
        }

        if (inventoryEnabled == true)
        {
            inventory.SetActive(true);
            mouseLook.mouseSensivility = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            inventory.SetActive(false);
            mouseLook.mouseSensivility = 200;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }


}
