using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ObjON : MonoBehaviour
{

    public GameObject LinternaImage;
    public GameObject LinternaDeSuelo;
    public GameObject LinternaDePlayer;
    public Inventory inventory;
    public GameObject TextLinternaPuedo;

    bool isOnlinte;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnlinte)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                LinternaImage.SetActive(true);
                LinternaDePlayer.SetActive(true);
                LinternaDeSuelo.SetActive(false);
                TextLinternaPuedo.SetActive(false);
                inventory.TimelineApagando.Play();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            TextLinternaPuedo.SetActive(true);
            isOnlinte = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Mira"))
        {
            TextLinternaPuedo.SetActive(false);
            isOnlinte = false;
        }
    }
}
