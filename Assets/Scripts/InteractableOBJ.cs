using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableOBJ : MonoBehaviour
{
    public GameObject Inspection;
    public InspectionObj inspectionObj;
    public InpectionON inpectionON;
    public int index;
    public bool isOBJ = false;
    public GameObject vacio = null;

    public MouseLook mouseLook;


    void Start()
    {
        isOBJ = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOBJ)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                inpectionON.enabled = true;
                this.enabled = false;
                Inspection.SetActive(true);
                inspectionObj.TurnOnInspection(index);
                Cursor.visible = true;
                mouseLook.enabled = false;
            }


        }      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ampolleta"))
        {
            inpectionON.inspectedObj = other.gameObject;
            isOBJ = true;
        }
        if (other.CompareTag("vacio"))
        {
            inpectionON.inspectedObj = other.gameObject;
            vacio = other.gameObject;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ampolleta"))
        {
            isOBJ = false;
        }

        if (other.CompareTag("vacio"))
        {
            vacio = null;
        }
    }
}
