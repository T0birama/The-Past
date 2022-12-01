using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note1Mano : MonoBehaviour
{
    public GameObject notaMesa;
    public GameObject Dejar1;

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
                Dejar1.SetActive(false);
                notaMesa.SetActive(true);
                gameObject.SetActive(false);
            }
        }
        
    }
}
