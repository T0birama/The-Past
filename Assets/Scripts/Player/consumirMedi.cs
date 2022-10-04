using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class consumirMedi : MonoBehaviour
{
    public Item medi;
    public GameObject objMediMano;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( objMediMano.activeSelf)
        {
            if (Input.GetMouseButtonDown(0))
            {
                medi.recuperarCordura();
                gameObject.SetActive(false);
            }
        }
    }
}
