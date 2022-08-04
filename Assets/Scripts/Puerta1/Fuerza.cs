using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerza : MonoBehaviour
{
    public Rigidbody rb;
    public float fuerza;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(transform.right * fuerza);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
