using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using Cinemachine;

public class Entra : MonoBehaviour
{
    public PlayableDirector Timeline;
    public PlayableDirector TimelineVamos;
    public Locura locura;
    public GameObject luces;
    public Transform Virtualcamera;
    public GameObject fantasma;
    public Transform EnemyTransform;
   
    //public SiSeApagaEstePrendoEste si;
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
            TimelineVamos.Play();
            Timeline.Play();
            locura.cordura -= 0.1f ;
            
            locura.volume.weight += 0.1f ;
            StartCoroutine(lucesApagadas());

            Virtualcamera.LookAt(EnemyTransform);

        }
    }

    IEnumerator lucesApagadas()
    {
        yield return new WaitForSeconds(3);
        luces.SetActive(false);
        Virtualcamera.LookAt(null);


        gameObject.SetActive(false);
        fantasma.SetActive(true);
        //si.prendido = true;
    }

}
