using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Linterna : MonoBehaviour
{
    public GameObject Lantern;
    public Locura loc;
    public LuzReduction lu;

    bool esta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            esta = !esta;
            if (esta)
            {
         
                Lantern.SetActive(false);
            }
            else
            {
                
                Lantern.SetActive(true);
                

            }
            
        }

        if(Lantern.activeSelf == true && lu.linterna.intensity > 0)
        {
           //lu.IntensidadDown();
           loc.volume.weight -= 0.1f * Time.deltaTime;
           loc.cordura += 0.1f * Time.deltaTime;
        }
        
    }
}
