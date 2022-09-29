using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MouseLook : MonoBehaviour
{
    public GameObject mano;

    public float distance = 10;
    public float mouseSensivility = 200f;

    public Transform playerBody;

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    private void Update()
    {
        RaycastHit[] hits= Physics.RaycastAll(transform.position, transform.forward, distance);
        Debug.DrawRay(transform.position, transform.forward * distance, Color.red);

        foreach (RaycastHit hit in hits)
        {
            Debug.Log(hit.collider.tag);
            
            if (hit.collider.CompareTag("ampolleta"))
            {
                Debug.Log(hit.collider.tag);
            }

            else
            {

                mano.SetActive(false);
                
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
