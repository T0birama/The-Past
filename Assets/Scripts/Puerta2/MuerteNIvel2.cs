using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MuerteNIvel2 : MonoBehaviour
{
    public Enemy2 en2;
    public PlayableDirector timelinemuerte;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Muerte());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StopCoroutine(Muerte());

        }
    }

    IEnumerator Muerte()
    {
        yield return new WaitForSeconds(1);
        TimelineMuerte();
    }

    public void TimelineMuerte()
    {
        en2.soloPaMorir();
        timelinemuerte.Play();
        
    }
}
