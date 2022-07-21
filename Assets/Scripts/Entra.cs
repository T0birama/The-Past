using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;

public class Entra : MonoBehaviour
{
    public PlayableDirector Timeline;
    public Locura locura;
   
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
        if(other.CompareTag("Player"))
        {
            Timeline.Play();
            locura.cordura -= 0.1f ;
            gameObject.SetActive(false);
            locura.volume.weight += 0.1f ;

        }
    }

}
