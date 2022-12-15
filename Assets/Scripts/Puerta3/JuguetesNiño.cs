using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuguetesNiño : MonoBehaviour
{
    public GameObject Final;
    public GameObject[] colisiones;
    public LuzCanbiando luz;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        luz.enabled = false;
        bool TodosDesactivados = true;
        foreach (GameObject g in colisiones)
        {
            if (g.activeSelf)
            {
                TodosDesactivados = false;
                luz.enabled = true;
               

            }
        }
        

        Final.SetActive(TodosDesactivados);
        
    }
}
