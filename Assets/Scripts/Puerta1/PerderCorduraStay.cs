using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerderCorduraStay : MonoBehaviour
{

    public Locura loc;
    public AudioSource stayAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            loc.cordura = 0.8f;
            loc.volume.weight = 0.2f;
            stayAudio.enabled = true;
            StartCoroutine(staynot());
        }
    }

    IEnumerator staynot()
    {
        yield return new WaitForSeconds(8);
        gameObject.SetActive(false);
        
    }


}
