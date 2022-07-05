using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MouseLookParque : MonoBehaviour
{
    public Texture2D cursorActivo, cursorNada;

    public PlayableDirector timelineCanvas;
    public PlayableDirector timelineCrossAir;

    public bool OnAnimation;

    public float distance = 20;
    public float mouseSensivility = 200f;

    public Transform playerBody;

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }



    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivility * Time.deltaTime; 
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivility * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f , 90f);
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}

    