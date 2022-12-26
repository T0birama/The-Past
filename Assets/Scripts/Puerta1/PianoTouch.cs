using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoTouch : MonoBehaviour
{
    public bool PuedoTocar;
    public GameObject SonidoDePiano;
    public float TiempoDeSonido = 2;
    public GameObject P1;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PuedoTocar == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SonidoDePiano.SetActive(true);
                StartCoroutine(SiguienteSonido());
                animator.enabled = true;
            }
        }
    }

    IEnumerator SiguienteSonido()
    {
        yield return new WaitForSeconds(TiempoDeSonido);
        gameObject.SetActive(false);
        P1.SetActive(true);
        SonidoDePiano.SetActive(false);
        animator.enabled = false;
    }
}
