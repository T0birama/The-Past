using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MouseLook : MonoBehaviour
{
    public Texture2D cursorActivo, cursorNada;

    public PlayableDirector timelineCanvas;
    public PlayableDirector timelineCrossAir;

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
                timelineCanvas.Play();
            
                ampolleta.isOn = true;
                OnAnimation=true;
                break;
                
            }

            else if (hit.collider.CompareTag("ampolleta1"))
            {
                timelineCanvas.Play();
               
                ampolleta1.isOn = true;
                OnAnimation = true;
                break;
               
            }

            else if(hit.collider.CompareTag("ampolletavacia"))
            {
                timelineCanvas.Play();
                vampolleta.isOn = true;
                OnAnimation = true;
                
                break;
               

            }

            else if(hit.collider.CompareTag("ampolletavacia1"))
            {
                timelineCanvas.Play();
                vampolleta1.isOn = true;
                OnAnimation = true;
                
                break;
               
            }
            else if (hit.collider.CompareTag("medicamento"))
            {
                timelineCanvas.Play();
                item.IsOnMedi = true;
                OnAnimation = true;
                
                break;
              
            }
            else if (hit.collider.CompareTag("linterna"))
            {
                timelineCanvas.Play();
                
                linterna.isOnlinte = true;
                OnAnimation = true;
                break;
               
            }
            else if (hit.collider.CompareTag("llave")) 
            {
                timelineCanvas.Play();
                
                llave.isLlave = true;
                OnAnimation = true;
                break;
               
            }
            else if (hit.collider.CompareTag("llave1"))
            {
                timelineCanvas.Play();

                llave1.isLlave = true;
                OnAnimation = true;
                break;

            }
            else if (hit.collider.CompareTag("pilas"))
            {
                timelineCanvas.Play();
                pilas.isOnPilas = true;
               
                OnAnimation = true;
                break;
               
            }

            else if (hit.collider.CompareTag("pilas1"))
            {
                timelineCanvas.Play();
                pilas1.isOnPilas = true;

                OnAnimation = true;
                break;

            }
            else if (hit.collider.CompareTag("pilas2"))
            {
                timelineCanvas.Play();
                pilas2.isOnPilas = true;

                OnAnimation = true;
                break;

            }

            else
            {
                if (OnAnimation)
                {
                    timelineCrossAir.Play();
                    OnAnimation = false;
                    timelineCanvas.Stop();
                }
                

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


    public LayerMask layerMask;
    void AlternativaRaycast()
    {
        Ray ray = new Ray(transform.position , transform.forward);
        RaycastHit hit;

        if(Physics.Raycast(ray,out hit, distance))
        {

            if (hit.collider.CompareTag("ampolleta"))
            {
                timelineCanvas.Play();

                ampolleta.isOn = true;
                OnAnimation = true;
              

            }

            else if (hit.collider.CompareTag("ampolleta1"))
            {
                timelineCanvas.Play();

                ampolleta1.isOn = true;
                OnAnimation = true;
                
            }

            else if (hit.collider.CompareTag("ampolletavacia"))
            {
                timelineCanvas.Play();
                vampolleta.isOn = true;
                OnAnimation = true;

              


            }

            else if (hit.collider.CompareTag("ampolletavacia1"))
            {
                timelineCanvas.Play();
                vampolleta1.isOn = true;
                OnAnimation = true;

                

            }
            else if (hit.collider.CompareTag("medicamento"))
            {
                timelineCanvas.Play();
                item.IsOnMedi = true;
                OnAnimation = true;

            

            }
            else if (hit.collider.CompareTag("linterna"))
            {
                timelineCanvas.Play();

                linterna.isOnlinte = true;
                OnAnimation = true;
             

            }
            else if (hit.collider.CompareTag("llave"))
            {
                timelineCanvas.Play();

                llave.isLlave = true;
                OnAnimation = true;
              

            }
            else if (hit.collider.CompareTag("pilas"))
            {
                timelineCanvas.Play();
                pilas.isOnPilas = true;

                OnAnimation = true;
             

            }

            else
            {
                if (OnAnimation)
                {
                    OnAnimation = false;
                    timelineCanvas.Stop();
                    timelineCrossAir.Play();
                }


                vampolleta1.isOn = false;
                vampolleta.isOn = false;
                ampolleta.isOn = false;
                ampolleta1.isOn = false;

                item.IsOnMedi = false;



                linterna.isOnlinte = false;


                llave.isLlave = false;

                pilas.isOnPilas = false;
                OnAnimation = false;


            }
        }
        else
        {
            print("NO HAY NADA");
            
            OnAnimation = false;

        }


    }
}
