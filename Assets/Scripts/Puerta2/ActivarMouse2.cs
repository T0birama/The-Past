using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarMouse2 : MonoBehaviour
{
    public MouseLook2 ml;
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
        yield return new WaitForSeconds(0.2f);
        ml.enabled = true;


    }
}
