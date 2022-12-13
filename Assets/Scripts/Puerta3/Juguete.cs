using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juguete : MonoBehaviour
{

    public bool puedeAgarrarJuguete;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puedeAgarrarJuguete)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                gameObject.SetActive(false);

            }
        }
    }
}
