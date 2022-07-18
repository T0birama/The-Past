using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * 150;
            float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * 150;

            Vector3 mouse = new Vector3(mouseY, -mouseX);

            transform.rotation = transform.rotation * Quaternion.Euler(mouse);
        }

    }
}
