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

    public RaycastHit hit;

    [Header("Puertas")]

    [Header("Otras cosas")]
    public TimelinePlay timelineCosa;
    public Entidad1 ni�o1;
    public Entidad1 ni�o2;
    public Entidad1Fin ni�o3;
    

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    private void Update()
    {
       
        Debug.DrawRay(transform.position, transform.forward * distance, Color.red);

        if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
        {
            if (hit.collider.CompareTag("medicamento"))
            {

                //hit.collider.gameObject.GetComponent<Item>().IsOnMedi = true;
                //hit.collider.gameObject.GetComponent<Item>().textoRecogerMedi.SetActive(true);
                medicamentoObj.IsOnMedi = true;
                medicamentoObj.textoRecogerMedi.SetActive(true);

            }
            else if (hit.collider.CompareTag("kid"))
            {
                mano.SetActive(true);
                ni�o1.PuedoAgarrar = true;
            }
            else if (hit.collider.CompareTag("kid2"))
            {
                mano.SetActive(true);
                ni�o2.PuedoAgarrar = true;

            }
            else if (hit.collider.CompareTag("kid3"))
            {
                mano.SetActive(true);
                ni�o3.Agarrar = true;

            }
            else if (hit.collider.CompareTag("linterna"))
            {
                mano.SetActive(true);
                linternaObj.isOnlinte = true;
                linternaObj.TextLinternaPuedo.SetActive(true);
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
                linternaObj.TextLinternaPuedo.SetActive(false);
                linternaObj.isOnlinte = false;
                medicamentoObj.textoRecogerMedi.SetActive(false);
                medicamentoObj.IsOnMedi = false;
                ni�o1.PuedoAgarrar = false;
                ni�o2.PuedoAgarrar = false;

            }
            else if (hit.collider.CompareTag("Fantasmita"))
            {
                hit.collider.gameObject.SetActive(false);
            }
            else
            {
                medicamentoObj.textoRecogerMedi.SetActive(false);
                medicamentoObj.IsOnMedi = false;
                linternaObj.isOnlinte = false;
                mano.SetActive(false);
                linternaObj.TextLinternaPuedo.SetActive(false);
                ni�o1.PuedoAgarrar = false;
                ni�o2.PuedoAgarrar = false;

            }
        }
        else
        {
            medicamentoObj.textoRecogerMedi.SetActive(false);
            medicamentoObj.IsOnMedi = false;
            linternaObj.isOnlinte = false;
            mano.SetActive(false);
            linternaObj.TextLinternaPuedo.SetActive(false);
            ni�o1.PuedoAgarrar = false;
            ni�o2.PuedoAgarrar = false;

        }

        float mouseX = Input.GetAxis("Mouse X") * mouseSensivility * Time.deltaTime; 
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivility * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f , 90f);
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }


    
       

    
}
