using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Entidad1Fin : MonoBehaviour
{
    public bool Agarrar;
    public PlayableDirector timelineNiņo3;
    public GameObject navMama;
    public GameObject salida;

    public GameObject estasLuces;
    public GameObject otrasLuces;

    public GameObject TimelineNiņo3ParaParar;
    // Start is called before the first frame update
    void Start()
    {
        Agarrar = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Agarrar == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                timelineNiņo3.Play();
                salida.SetActive(true);
                navMama.SetActive(false);
                estasLuces.SetActive(false);
                otrasLuces.SetActive(true);
                StartCoroutine(ApagarTimeline());
            
            }
        }
        
    }

    IEnumerator ApagarTimeline()
    {
        yield return new WaitForSeconds(5);
        TimelineNiņo3ParaParar.SetActive(false);

    }
}
