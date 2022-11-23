using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LuzCanbiando : MonoBehaviour
{
    public PlayableDirector TimelineLuzApagar;
    public PlayableDirector TimelineLuzPrender;
    public float TiempoDeNoche;
    public float TiemporDeDia;

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
        TimelineLuzApagar.Stop();
        StartCoroutine(EmpezarAMoverse());

    }

    IEnumerator EmpezarAMoverse()
{
        yield return new WaitForSeconds(TiemporDeDia);
        TimelineLuzApagar.Play();
        TimelineLuzPrender.Stop();
        StartCoroutine(ApagarLuz());

    }
}
