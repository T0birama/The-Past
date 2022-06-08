using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mira : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 8;
        layerMask = ~layerMask;
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),out hit, 10f,layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)* hit.distance, Color.blue);
            Debug.Log(gameObject.name);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1, Color.red);
            Debug.Log("no le pego");
        }
    }
}
