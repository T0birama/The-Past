using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public GameObject Lantern;
    bool esta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            esta = !esta;
            if (esta)
            {
                Lantern.SetActive(false);
            }
            else
            {
                Lantern.SetActive(true);
            }
            
        }
        
    }
}
