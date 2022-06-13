using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stay : MonoBehaviour
{
    public Enemy1 enemy;
    public Enemy1 enemy2;
    public Enemy1 enemy3;
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
            enemy.SCP173Nav.enabled = true;
            enemy2.SCP173Nav.enabled = true;
            enemy3.SCP173Nav.enabled = true;
        }
    }

}

