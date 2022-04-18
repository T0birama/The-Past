using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject canvasInventory;
    public GameObject Ampolleta;
    public GameObject AmpolletaItem;
    public MouseLook mouseLook;
    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            canvasInventory.SetActive(true);
            mouseLook.mouseSensivility = 0;
            playerMovement.speed = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else 
        {
            canvasInventory.SetActive(false);
            mouseLook.mouseSensivility = 400;
            playerMovement.speed = 7.5f;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

        }

        if(Ampolleta.activeSelf == false)
        {
            AmpolletaItem.SetActive(true);
        }
    }
}
