using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InpectionON : MonoBehaviour
{
    public GameObject Inspection;
    public InspectionObj inspectionObj;
    public int index;
    public bool isOBJ = false;

    public MouseLook mouseLook;
    public GameObject Bombilla;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOBJ)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Inspection.SetActive(true);
                inspectionObj.TurnOnInspection(index);
                mouseLook.enabled = false;
                Bombilla.SetActive(false);
            }
        } 

        if(Inspection.activeSelf == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Inspection.SetActive(false);
                inspectionObj.TurnOffInspection();
                mouseLook.enabled = true;
                Bombilla.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ampolleta"))
        {
            isOBJ = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ampolleta"))
        {
            isOBJ = false;
        }

    }

}
