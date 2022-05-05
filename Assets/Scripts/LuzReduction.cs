using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class LuzReduction : MonoBehaviour
{
    public HDAdditionalLightData linterna;
    public float reduction;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        linterna.intensity = Mathf.Clamp(linterna.intensity,0, 1772.727f);
        if(linterna.intensity == 0)
        {
            linterna.enabled = false;
        }
    }

    public void IntensidadDown()
    {
        linterna.intensity -= reduction * Time.deltaTime;
    }

}
