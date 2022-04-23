using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int id;
    public string type;
    public string description;
    public Sprite icon;

    [HideInInspector]
    public bool pickedUp;

    public bool equipped;

    private void Update()
    {
        if(equipped == true)
        {

        }
    }

    public void ItemUsage()
    {
        if(type == "Luz")
        {
            equipped = true;
        }
    }
}
