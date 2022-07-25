using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RecargaBat : MonoBehaviour
{
    
    public GameObject Pilas;
    public GameObject imageBat;
    
    public Inventory inventory; 
    
    public bool isOnPilas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnPilas)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Pilas.SetActive(false);
                
                imageBat.SetActive(false);
                
                
                inventory.Baterias += 1;
                inventory.TimelineApagando.Play();
            }
        }

        
    }

    



}
