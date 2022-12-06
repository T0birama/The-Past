using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerderCorduraStay : MonoBehaviour
{
    public Locura loc;
    
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
            loc.cordura -= 0.5f * Time.deltaTime;
            loc.volume.weight += 0.5f * Time.deltaTime;

        }
    }



}
