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
                Inspection.SetActive(false);
                inspectionObj.TurnOffInspection();
                Cursor.visible = false;
                mouseLook.enabled = (true);
                Bombilla.SetActive(false);
                interactableOBJ.enabled = true;
                interactableOBJ.isOBJ = false;
            }
        } 

        if(Inspection.activeSelf == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                interactableOBJ.enabled = true;
                Inspection.SetActive(false);
                inspectionObj.TurnOffInspection();
                Cursor.visible = false;
                mouseLook.enabled = (true);
            }
        }
    }

    

}
