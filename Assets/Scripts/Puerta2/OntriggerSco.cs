using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OntriggerSco : MonoBehaviour
{
    public Collider playercollider;
    private void OnTriggerEnter(Collider playercollider)
    {
        Debug.Log("perdiste");
        
    }
}
