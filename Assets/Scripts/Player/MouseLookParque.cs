using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MouseLookParque : MonoBehaviour
{
    public GameObject mano;
    [Header("Mouse Settings")]
    public float distance = 1f;

    public float mouseSensivility = 200f;

    public Transform playerBody;
    [Header("Objetos/linterna/Medicamento")]
    

    public RaycastHit hit;

    [Header("Puertas")]

    [Header("Otras cosas")]
    public GameObject TextNoVeoNada;


    public float xRotation = 0f;
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
            if (hit.collider.CompareTag("Untagged"))
            {
                mano.SetActive(false);


            }
            if (hit.collider.CompareTag("Collider"))
            {
                TextNoVeoNada.SetActive(true);
                StartCoroutine(devolverText());
              
            }
            
        }

        float mouseX = Input.GetAxis("Mouse X") * mouseSensivility * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivility * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    IEnumerator devolverText()
    {
        yield return new WaitForSeconds(2);
        TextNoVeoNada.SetActive(false);
    }

}

    