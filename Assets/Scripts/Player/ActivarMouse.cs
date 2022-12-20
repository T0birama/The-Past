using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarMouse : MonoBehaviour
{
    public MouseLook ml;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(mouseTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator mouseTime()
    {
        yield return new WaitForSeconds(1);
        ml.enabled = true;


    } 
}
