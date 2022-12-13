using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagarPlayer : MonoBehaviour
{
    public CharacterController pj;
    public float cuantoTiempo = 15f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimeDeDemora());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TimeDeDemora()
    {
        yield return new WaitForSeconds(cuantoTiempo);
        pj.enabled = true;
    }
}
