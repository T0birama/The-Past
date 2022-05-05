using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ActivarRigid : MonoBehaviour
{
    public Rigidbody rb;
    public Locura locura;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rb.isKinematic = false;
            locura.cordura += 0.1f;
            locura.volume.weight += 0.1f;
            gameObject.SetActive(false);
        }
    }
}
