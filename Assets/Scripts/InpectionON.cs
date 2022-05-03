using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InpectionON : MonoBehaviour
{
    public GameObject Inspection;
    public InspectionObj inspectionObj;

    public InteractableOBJ interactableOBJ;
    public MouseLook mouseLook;


    

    public GameObject inspectedObj = null;

    
    void Update()
    {
        if (Inspection.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                inspectionObj.TurnOnInspection(0);
                Inspection.SetActive(false);
                mouseLook.mouseSensivility=200;
                interactableOBJ.isOBJ = false;
                mouseLook.enabled = true;
                this.enabled=false;
                interactableOBJ.enabled=true;
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

    

    

}
