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
    public MouseLook mouse;
    private void Start()
    {

        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            mouse.mouseSensivility = 0;
            TimelinePrendio.Play();
            TimelineApagando.Stop();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        } 
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            mouse.mouseSensivility = 200;
            TimelineApagando.Play();
            TimelinePrendio.Stop();
            
            Cursor.lockState = CursorLockMode.Locked;

        }

        
       
    }

    

    


}
