using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ObjON : MonoBehaviour
{

    //public GameObject LinternaImage;
    public GameObject LinternaDeSuelo;
    public GameObject LinternaDePlayer;
    public GameObject ColliderdeCordura;
    //public Inventory inventory;
   
    public bool isOnlinte;
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
                //LinternaImage.SetActive(true);
                LinternaDePlayer.SetActive(true);
                LinternaDeSuelo.SetActive(false);
                ColliderdeCordura.SetActive(false);
                
                //inventory.TimelineApagando.Play();

                
            }
        }
    }

    

   
}
