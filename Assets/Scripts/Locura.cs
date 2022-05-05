using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Rendering;

public class Locura : MonoBehaviour
{
    
    public float cordura = 0f;
    public Image cerebro;
    public Volume volume;
    // Start is called before the first frame update
    void Start()
    {
        
        
       
    }

    // Update is called once per frame
    void Update()
    {
        cerebro.color = new Color(cerebro.color.r, cerebro.color.g, cerebro.color.b, cordura);

        Color color = cerebro.color;

        cordura = Mathf.Clamp(cordura, 0, 1);
        if (cordura == 1f)
        {
           color.a = 0;
            Debug.Log("MURIO");
        }
        else
        if(cordura == 0.9f)
        {
            color.a = 0.1f;
        }
        else
        if(cordura == 0.8f)
        {
            color.a = 0.2f;
        }
        else
        if (cordura == 0.7f)
        {
            color.a = 0.3f;
        }
        else
        if (cordura == 0.6f)
        {
            color.a = 0.4f;
        }
        else
        if (cordura == 0.5f)
        {
            color.a = 0.5f;
        }
        else
        if (cordura == 0.4f)
        {
            color.a = 0.6f;
        }
        else
        if (cordura == 0.3f)
        {
            color.a = 0.7f;
        }
        else
        if (cordura == 0.2f)
        {
            color.a = 0.8f;
        }
        else
        if (cordura == 0.1f)
        {
            color.a = 0.9f;
        }
        else
        if (cordura == 0f)
        {
            
            color.a = 100f;
        }

        volume.weight = Mathf.Clamp(volume.weight,0,1);

        cordura +=0.01f * Time.deltaTime; 
        volume.weight += 0.01f * Time.deltaTime;



        




    }
}
