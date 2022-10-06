using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiSeApagaEstePrendoEste : MonoBehaviour
{
    public GameObject obj1SeApaga;
    public GameObject obj2SePrende;
    public bool prendido;
    // Start is called before the first frame update
    void Start()
    {
       prendido = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
        if(prendido == true)
        {
            obj2SePrende.SetActive(true);
        }
        else if(prendido == false)
        {
            obj1SeApaga.SetActive(true);
        }
       
    }
}
