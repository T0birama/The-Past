using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apretar : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;

    bool esta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            esta = !esta;
            if (esta)
            {
                obj1.SetActive(false);
                obj2.SetActive(true);
            }
            else
            {
                obj1.SetActive(true);
                obj2.SetActive(false);
            }
        }
        
    }
}
