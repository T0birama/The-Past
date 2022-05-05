using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyON : MonoBehaviour
{
    public Rigidbody cosas;
    public GameObject luz;
    public GameObject luz2;
    public GameObject sombra;

    public int index;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(rbON());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator rbON()
    {
        yield return new WaitForSeconds(index);
        cosas.isKinematic = false;
        luz.SetActive(false);
        luz2.SetActive(false);
        sombra.SetActive(true);

    }
}
