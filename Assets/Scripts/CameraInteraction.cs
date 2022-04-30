using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInteraction : MonoBehaviour
{
    public new Transform camera; 
    public float rayDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(camera.position, camera.forward, Color.red);
        RaycastHit hit;
        if(Physics.Raycast(camera.position, camera.forward, out hit, rayDistance))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
