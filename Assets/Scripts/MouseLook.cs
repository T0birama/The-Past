using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseLook : MonoBehaviour
{
    public iAmpolleta ampolleta;
    public iAmpolleta ampolleta1;
    public iAmpolleta ampolleta2;
    
    
    public Vampolleta vampolleta;
    public Vampolleta vampolleta1;
    public Vampolleta vampolleta2;
    

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
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward * 900, out hit))
        {
            Debug.DrawRay(transform.position , transform.forward, Color.red);

            if (hit.collider.CompareTag("ampolleta"))
            {
                ampolleta.CanvasPuedoAgarrar.SetActive(true);
                ampolleta.isOn = true;
               
            }
            else
            {
                ampolleta.CanvasPuedoAgarrar.SetActive(false);
                ampolleta.isOn = false;
                
            }
            
            if (hit.collider.CompareTag("ampolletavacia"))
            {
                vampolleta.isOn= true;
                vampolleta.CanvasPuedoDejar.SetActive(true);
                
            }
            else
            {
                vampolleta.isOn = false;
                vampolleta.CanvasPuedoDejar.SetActive(false);
               
            }

            if (hit.collider.CompareTag("ampolleta1"))
            {

                ampolleta1.CanvasPuedoAgarrar.SetActive(true);
                ampolleta1.isOn = true;
            }
            else
            {

                ampolleta1.CanvasPuedoAgarrar.SetActive(false);
                ampolleta1.isOn = false;
            }
            if (hit.collider.CompareTag("ampolletavacia1"))
            {
                
                vampolleta1.isOn = true;
                vampolleta1.CanvasPuedoDejar.SetActive(true);
            }
            else
            {
                
                vampolleta1.isOn = false;
                vampolleta1.CanvasPuedoDejar.SetActive(false);
            }
        }

        float mouseX = Input.GetAxis("Mouse X") * mouseSensivility * Time.deltaTime; 
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivility * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f , 90f);
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
