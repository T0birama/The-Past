using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Entidad1 : MonoBehaviour
{
    public GameObject esteKid;
    public GameObject otroKid;
    public bool PuedoAgarrar;
    public GameObject estasLuces;
    public GameObject otrasLuces;
    public PlayableDirector TimelinePillado;
    public GameObject navmesh;

    // Start is called before the first frame update
    void Start()
    {
        PuedoAgarrar = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(PuedoAgarrar == true)
       {
            if (Input.GetKeyDown(KeyCode.E))
            {
                esteKid.SetActive(false);
                otroKid.SetActive(true);
                estasLuces.SetActive(false);
                otrasLuces.SetActive(true);

                TimelinePillado.Play();
                navmesh.SetActive(true);
            }
       }



    }
}
