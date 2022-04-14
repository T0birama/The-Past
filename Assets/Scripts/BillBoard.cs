using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BillBoard : MonoBehaviour
{
    Vector3 cameraDir;
    public CinemachineVirtualCamera cameras;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraDir = cameras.transform.forward;
        cameraDir.y = 0;

        transform.rotation = Quaternion.LookRotation(cameraDir);
    }
}
