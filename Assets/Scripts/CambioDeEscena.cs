using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    public int sceneIndex;
    public GameObject CanEnter;
    public bool canIn;
    // Start is called before the first frame update
    void Start()
    {
        canIn = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (canIn)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(sceneIndex);
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canIn = true;
            CanEnter.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canIn = false;
            CanEnter.SetActive(false);
        }
    }
}
