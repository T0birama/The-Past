using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelInspection : MonoBehaviour
{
    public GameObject inpectionCanvas;
    public MouseLook mouseLook;
    public PlayerMovement movement; 
    public Zoom zoom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inpectionCanvas.activeSelf == true)
        {
            mouseLook.mouseSensivility = 0f;
            movement.speed = 0f;
            zoom.enabled = false;

            if (Input.GetMouseButtonDown(1))
            {
                inpectionCanvas.SetActive(false);
                movement.speed = 5;
                mouseLook.mouseSensivility = 200;
                zoom.enabled = true;
            }
        }
    }
}
