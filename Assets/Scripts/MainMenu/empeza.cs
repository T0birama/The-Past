using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empeza : MonoBehaviour
{
    public GameObject tuto;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(seApagan());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator seApagan()
    {
        yield return new WaitForSeconds(5);
        tuto.SetActive(false);
    }
}
