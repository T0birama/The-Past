using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuguetesNiño : MonoBehaviour
{
    public GameObject Final;
    public GameObject[] colisiones;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool TodosDesactivados = true;
        foreach (GameObject g in colisiones)
        {
            if (g.activeSelf)
            {
                TodosDesactivados = false;
            }
        }

        Final.SetActive(TodosDesactivados);
    }
}
