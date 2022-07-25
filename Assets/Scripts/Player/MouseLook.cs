using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MouseLook : MonoBehaviour
{
    public GameObject mano;

    
    

    public iAmpolleta ampolleta;
    public iAmpolleta ampolleta1;
    public iAmpolleta ampolleta2;
    
    
    public Vampolleta vampolleta;
    public Vampolleta vampolleta1;
    public Vampolleta vampolleta2;
    
    public Item item;

    public ObjON linterna;

    public Llave llave;
    public Llave llave1;

    public RecargaBat pilas;
    public RecargaBat pilas1;
    public RecargaBat pilas2;

    public bool OnAnimation;

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
    void Update()
    {
        

        
        
        RaycastHit[] hits= Physics.RaycastAll(transform.position, transform.forward, distance);
        Debug.DrawRay(transform.position, transform.forward * distance, Color.red);

        foreach (RaycastHit hit in hits)
        {
            Debug.Log(hit.collider.tag);
            
            if (hit.collider.CompareTag("ampolleta"))
            {
                
                mano.SetActive(true);
                ampolleta.isOn = true;
                OnAnimation=true;
                break;
                
            }

            else if (hit.collider.CompareTag("ampolleta1"))
            {
                
                mano.SetActive(true);
                ampolleta1.isOn = true;
                OnAnimation = true;
                break;
               
            }

            else if(hit.collider.CompareTag("ampolletavacia"))
            {
                
                vampolleta.isOn = true;
                OnAnimation = true;
                mano.SetActive(true);
                break;
               

            }

            else if(hit.collider.CompareTag("ampolletavacia1"))
            {
                
                vampolleta1.isOn = true;
                OnAnimation = true;
                mano.SetActive(true);

                break;
               
            }
            else if (hit.collider.CompareTag("medicamento"))
            {
                
                item.IsOnMedi = true;
                OnAnimation = true;
                mano.SetActive(true);

                break;
              
            }
            else if (hit.collider.CompareTag("linterna"))
            {
               
                mano.SetActive(true);
                linterna.isOnlinte = true;
                OnAnimation = true;
                break;
               
            }
            else if (hit.collider.CompareTag("llave")) 
            {
                
                mano.SetActive(true);
                llave.isLlave = true;
                OnAnimation = true;
                break;
               
            }
            else if (hit.collider.CompareTag("llave1"))
            {
                
                mano.SetActive(true);
                llave1.isLlave = true;
                OnAnimation = true;
                break;

            }
            else if (hit.collider.CompareTag("pilas"))
            {
                
                pilas.isOnPilas = true;
                mano.SetActive(true);
                OnAnimation = true;
                break;
               
            }

            else if (hit.collider.CompareTag("pilas1"))
            {
                
                pilas1.isOnPilas = true;
                mano.SetActive(true);
                OnAnimation = true;
                break;

            }
            else if (hit.collider.CompareTag("pilas2"))
            {
                
                pilas2.isOnPilas = true;
                mano.SetActive(true);
                OnAnimation = true;
                break;

            }

            else
            {

                mano.SetActive(false);
                vampolleta1.isOn = false;
                vampolleta.isOn = false;
                ampolleta.isOn = false;
                ampolleta1.isOn = false;

                item.IsOnMedi = false;
                

                
                linterna.isOnlinte = false;

                
                llave.isLlave = false;
                llave1.isLlave = false;

                pilas.isOnPilas = false;
                pilas1.isOnPilas = false;
                pilas2.isOnPilas = false;
                
                
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
