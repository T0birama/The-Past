using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivarLuces : MonoBehaviour
{
    public GameObject luces;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeSelf == true)
        {
            luces.SetActive(false);
        }
    }
}
