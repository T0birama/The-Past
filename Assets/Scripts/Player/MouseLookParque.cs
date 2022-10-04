using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MouseLookParque : MonoBehaviour
{
    public Texture2D cursorActivo, cursorNada;
    private Transform Camara;

    public PlayableDirector timelineCanvas;
    public PlayableDirector timelineCrossAir;

    public bool OnAnimation;

    public float distance = 20;
    public float mouseSensivility = 200f;

    Vector2 sensivility;

    public Transform playerBody;

    //float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Camara = transform.Find("CameraPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");  
        float mouseY = Input.GetAxis("Mouse Y");

        if(mouseX != 0)
        {
            transform.Rotate(Vector3.up * mouseX * sensivility.x);
        }

        if(mouseY != 0)
        {
            //Camara.Rotate(Vector3.left * mouseY * sensivility.y);
            float angle = (Camara.localEulerAngles.x - mouseY * sensivility.y + 360 ) % 360;
            if(angle > 180)
            {
                angle -= 360;
            }
            angle = Mathf.Clamp(angle, -80 , 80); 
            Camara.localEulerAngles = Vector3.right * angle;
        }

        /*xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f , 90f);
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);*/
    }
}

    