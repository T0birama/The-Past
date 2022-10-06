using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MouseLook : MonoBehaviour
{
    public GameObject mano;
    [Header ("Mouse Settings")]
    public float distance = 15;
    public float distance2 = 100;
    public float mouseSensivility = 200f;

    public Transform playerBody;
    [Header ("Objetos/linterna/Medicamento")]
    public ObjON linternaObj;
    public Item medicamentoObj;

    [Header("Puertas")]

    [Header("Otras cosas")]
    public TimelinePlay timelineCosa;

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    private void Update()
    {
        RaycastHit[] hits = Physics.RaycastAll(transform.position , transform.forward, distance);
        RaycastHit[] hits2 = Physics.RaycastAll(transform.position , transform.forward, distance2);
        Debug.DrawRay(transform.position, transform.forward * distance, Color.red);

        foreach (RaycastHit hit2 in hits2)
        {
            Debug.Log(hit2.collider.tag);

            if (hit2.collider.CompareTag("Untagged"))
            {
                mano.SetActive(false);
                linternaObj.TextLinternaPuedo.SetActive(false);
                linternaObj.isOnlinte = false;
                medicamentoObj.textoRecogerMedi.SetActive(false);
                medicamentoObj.IsOnMedi = false;

            }
            else if (hit2.collider.CompareTag("Fantasmita"))
            {
                hit2.collider.gameObject.SetActive(false);
            }
        }
        foreach (RaycastHit hit in hits)
        {
            Debug.Log(hit.collider.tag);
            
            if (hit.collider.CompareTag("medicamento"))
            {
                medicamentoObj.IsOnMedi = true; 
                medicamentoObj.textoRecogerMedi.SetActive(true);
            }
            else if (hit.collider.CompareTag("linterna"))
            {
                linternaObj.isOnlinte = true;
                linternaObj.TextLinternaPuedo.SetActive(true);
            }
            else if (hit.collider.CompareTag("Cosa"))
            {
                hit.collider.gameObject.SetActive(false);
                timelineCosa.timelineplay();
            }
            else
            {
                medicamentoObj.textoRecogerMedi.SetActive(false);
                medicamentoObj.IsOnMedi = false;
                linternaObj.isOnlinte = false;
                mano.SetActive(false);
                linternaObj.TextLinternaPuedo.SetActive(false);

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
