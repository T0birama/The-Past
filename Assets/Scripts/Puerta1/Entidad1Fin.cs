using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Entidad1Fin : MonoBehaviour
{
    public bool Agarrar;
    public PlayableDirector timelineNi�o3;
    public GameObject navMama;
    public GameObject salida;

    public GameObject estasLuces;
    public GameObject otrasLuces;
    public GameObject objetivo1;
    public GameObject objetivo2;


    public GameObject TimelineNi�o3ParaParar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

    IEnumerator ApagarTimeline()
    {
        yield return new WaitForSeconds(5);
        TimelineNi�o3ParaParar.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objetivo1.SetActive(false);
            objetivo2.SetActive(true);
            timelineNi�o3.Play();
            salida.SetActive(true);
            navMama.SetActive(false);
            estasLuces.SetActive(false);
            otrasLuces.SetActive(true);
            StartCoroutine(ApagarTimeline());
        }
    }
}
