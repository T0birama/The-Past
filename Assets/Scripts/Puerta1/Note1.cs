using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note1 : MonoBehaviour
{
    
    public bool IsOnNote1;
    public GameObject NoteMano;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOnNote1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                NoteMano.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }


}
