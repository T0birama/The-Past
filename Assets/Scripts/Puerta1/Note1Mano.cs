using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note1Mano : MonoBehaviour
{
    public GameObject notaMesa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(notaMesa.activeSelf == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                notaMesa.SetActive(true);
                gameObject.SetActive(false);
            }
        }
        
    }
}
