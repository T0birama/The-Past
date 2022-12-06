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
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
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
