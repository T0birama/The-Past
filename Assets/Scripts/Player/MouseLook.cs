using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MouseLook : MonoBehaviour
{
    public GameObject mano;
    [Header ("Mouse Settings")]
    public float distance = 1f;
    
    public float mouseSensivility = 200f;

    public Transform playerBody;
    [Header ("Objetos/linterna/Medicamento")]
    public ObjON linternaObj;
    public Item medicamentoObj;
    public Note1 nota1;
    public PianoTouch P;
    public PianoTouch P2;
    public PianoTouch P3;


    public RaycastHit hit;

    [Header("Puertas")]

    [Header("Otras cosas")]
    public TimelinePlay timelineCosa;
    public Entidad1 niño1;
    public Entidad1 niño2;
    public Entidad1Fin niño3;
    

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Debug.DrawRay(transform.position, transform.forward * distance, Color.red);

        if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
        {
            if (hit.collider.CompareTag("medicamento"))
            {

                //hit.collider.gameObject.GetComponent<Item>().IsOnMedi = true;
                //hit.collider.gameObject.GetComponent<Item>().textoRecogerMedi.SetActive(true);
                mano.SetActive(true);
                medicamentoObj.IsOnMedi = true;
                

            }
            else if (hit.collider.CompareTag("Note1"))
            {
                mano.SetActive(true);
                nota1.IsOnNote1 = true;
                
            }
            else if (hit.collider.CompareTag("kid"))
            {
                
                niño1.PuedoAgarrar = true;
            }
            else if (hit.collider.CompareTag("kid2"))
            {
                
                niño2.PuedoAgarrar = true;

            }
            else if (hit.collider.CompareTag("kid3"))
            {
                
                niño3.Agarrar = true;

            }
            else if (hit.collider.CompareTag("linterna"))
            {
                mano.SetActive(true);
                linternaObj.isOnlinte = true;
              
            }
            else if (hit.collider.CompareTag("Cosa"))
            {
                mano.SetActive(true);
                hit.collider.gameObject.SetActive(false);
                timelineCosa.timelineplay();
            }
            else if (hit.collider.CompareTag("Untagged"))
            {
                mano.SetActive(false);
                P.PuedoTocar = false;
                P2.PuedoTocar = false;
                P3.PuedoTocar = false;

                linternaObj.isOnlinte = false;
                
                medicamentoObj.IsOnMedi = false;
                niño1.PuedoAgarrar = false;
                niño2.PuedoAgarrar = false;

            }
            else if (hit.collider.CompareTag("Fantasmita"))
            {
                hit.collider.gameObject.SetActive(false);
            }
            else if (hit.collider.CompareTag("teclado"))
            {
                mano.SetActive(true);
                P.PuedoTocar = true;
            }
            else if (hit.collider.CompareTag("teclado2"))
            {
                mano.SetActive(true);
                P2.PuedoTocar = true;
            }
            else if (hit.collider.CompareTag("teclado3"))
            {
                mano.SetActive(true);
                P3.PuedoTocar = true;
            }
            else
            {
                P.PuedoTocar = false;
                P2.PuedoTocar = false;
                P3.PuedoTocar = false;

                medicamentoObj.IsOnMedi = false;
                linternaObj.isOnlinte = false;
                mano.SetActive(false);
                
                niño1.PuedoAgarrar = false;
                niño2.PuedoAgarrar = false;
                nota1.IsOnNote1 = false;
                

            }
        }
        else
        {
            
            medicamentoObj.IsOnMedi = false;
            linternaObj.isOnlinte = false;
            mano.SetActive(false);
            
            niño1.PuedoAgarrar = false;
            niño2.PuedoAgarrar = false;
            nota1.IsOnNote1 = false;
            

        }

        float mouseX = Input.GetAxis("Mouse X") * mouseSensivility * Time.deltaTime; 
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivility * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f , 90f);
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }


    
       

    
}
