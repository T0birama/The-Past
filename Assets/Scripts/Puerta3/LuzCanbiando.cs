using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using TMPro;

public class LuzCanbiando : MonoBehaviour
{
    public PlayableDirector TimelineLuzApagar;
    public PlayableDirector TimelineLuzPrender;
    public GameObject ColliderLocura;
    public float TiempoDeNoche;
    public float TiemporDeDia;
    public TimerEntidades t1;
    public GameObject Textt1;
    public GameObject Textt2;
    public TimerEntidades t2;
    public GameObject Sol;
    public GameObject Luna;



    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(EmpezarAMoverse());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ApagarLuz()
    {
        yield return new WaitForSeconds(TiempoDeNoche);
        TimelineLuzPrender.Play();
        ColliderLocura.SetActive(true);
        TimelineLuzApagar.Stop();
        StartCoroutine(EmpezarAMoverse());
        t1.enabled = true;
        Textt1.SetActive(true);
        t2.enabled = false;
        Textt2.SetActive(false);
        Sol.SetActive(true);
        Luna.SetActive(false);

    }

    IEnumerator EmpezarAMoverse()
{
        yield return new WaitForSeconds(TiemporDeDia);
        TimelineLuzApagar.Play();
        ColliderLocura.SetActive(false);
        TimelineLuzPrender.Stop();
        StartCoroutine(ApagarLuz());
        t1.enabled = false;
        Textt1.SetActive(false);
        t2.enabled = true;
        Textt2.SetActive(true);
        Sol.SetActive(false);
        Luna.SetActive(true);

    }
}
