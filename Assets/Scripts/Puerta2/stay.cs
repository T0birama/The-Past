using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stay : MonoBehaviour
{
   
    public Enemy1 enemy2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
          
            enemy2.SCP173Nav.enabled = true;
            
        }
    }

}

