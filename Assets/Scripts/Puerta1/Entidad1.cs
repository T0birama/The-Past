using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entidad1 : MonoBehaviour
{
    public GameObject puerta1Gift;
    public GameObject[] entidad1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool todosEscondidos = true;
        foreach (GameObject g in entidad1)
        {
            if (g.activeSelf)
            {
                todosEscondidos = false;
            }
        }

        puerta1Gift.SetActive(todosEscondidos);
    }
}
