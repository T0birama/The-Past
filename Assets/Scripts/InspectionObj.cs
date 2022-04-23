using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionObj : MonoBehaviour
{
    public Item selectedObject;
    public  List<Item>inspectionObj;
    

    public void TurnOnInspection(int index)
    {
        gameObject.SetActive(true);
        
        
        for (int i = 0; i < inspectionObj.Count; i++)
        {
            inspectionObj[i].gameObject.SetActive(i == index);
        }

        selectedObject = inspectionObj[index];
    }

    public void TurnOffInspection()
    {
        inspectionObj.ForEach(c => c.gameObject.SetActive(false));
        selectedObject = null;
        gameObject.SetActive(false);

    }
}
