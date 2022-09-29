using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOBJ : MonoBehaviour
{
    public GameObject Lupita;
    public Zoom zoom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (zoom.fov == 35)
        {
            Lupita.SetActive(true);
        }
        else if (zoom.fov < 60)
        {
            Lupita.SetActive(false);
        }
    }
}
