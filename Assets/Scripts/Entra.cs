using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;

public class Entra : MonoBehaviour
{
    public PlayableDirector Timeline;
    public Locura locura;
    public GameObject luces;
    public GameObject audioA;
   
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
            
            locura.volume.weight += 0.1f ;
            StartCoroutine(lucesApagadas());

        }
    }

    IEnumerator lucesApagadas()
    {
        yield return new WaitForSeconds(5);
        luces.SetActive(false);
        audioA.SetActive(false);
        gameObject.SetActive(false);
    }

}
