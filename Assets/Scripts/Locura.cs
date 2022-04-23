using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Locura : MonoBehaviour
{
    
    public float cordura = 0f;
    public Image cerebro;
    // Start is called before the first frame update
    void Start()
    {
        
        
       
    }

    // Update is called once per frame
    void Update()
    {
        cerebro.color = new Color(cerebro.color.r, cerebro.color.g, cerebro.color.b, cordura);

        Color color = cerebro.color;
       
        if(cordura == 1f)
        {
           color.a = 0;
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

        




    }
}
