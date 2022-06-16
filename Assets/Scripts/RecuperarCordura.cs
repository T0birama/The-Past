using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class RecuperarCordura : MonoBehaviour
{
    public Locura locura;
    
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
        if (other.CompareTag("Player") && locura.cordura > 0 && locura.volume.weight > 0  )
        {
            locura.cordura -=0.05f * Time.deltaTime;
            locura.volume.weight -=0.05f * Time.deltaTime;
        }
    }
}
