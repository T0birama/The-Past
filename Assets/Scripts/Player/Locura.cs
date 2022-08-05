using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Rendering;

public class Locura : MonoBehaviour
{
    public Slider slider;
    
    public float cordura = 1f;
    public Volume volume;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
       
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = cordura;

        cordura = Mathf.Clamp(cordura, 0, 1);
        

        volume.weight = Mathf.Clamp(volume.weight,0,0.6f);

        perderCordura();
    } 

    public void perderCordura()
    {
        cordura -= 0.01f * Time.deltaTime;
        volume.weight += 0.01f * Time.deltaTime;
    }

    
}
