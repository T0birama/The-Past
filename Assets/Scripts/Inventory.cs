using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;

public class Inventory : MonoBehaviour
{
    public GameObject Canvas;
    public PlayableDirector TimelineApagando;
    public PlayableDirector TimelinePrendio;
    private void Start()
    {

        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TimelinePrendio.Play();
            TimelineApagando.Stop();
            
        } 
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            TimelineApagando.Play();
            TimelinePrendio.Stop();
            
        }

       
    }

    

    


}
