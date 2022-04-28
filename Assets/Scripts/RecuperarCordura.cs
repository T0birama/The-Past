using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class RecuperarCordura : MonoBehaviour
{
    public Locura locura;
    public Volume volume;
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
        if (other.CompareTag("Player") && locura.cordura > 0 && volume.weight > 0  )
        {
            locura.cordura -=0.01f * Time.deltaTime;
            volume.weight -=0.1f * Time.deltaTime;
            Debug.Log("ESTOY DENTRO");
        }
       
    }
}
