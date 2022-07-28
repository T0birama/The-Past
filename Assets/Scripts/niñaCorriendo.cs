using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; 
public class niñaCorriendo : MonoBehaviour
{
    public GameObject niña;
    public PlayableDirector TimelineNiña;
    public Locura loc;
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
            niña.SetActive(true);
            TimelineNiña.Play();
            StartCoroutine(deniña());
            loc.cordura -= 0.05f;
            loc.volume.weight += 0.01f;
            gameObject.SetActive(false);
        }
    }

    IEnumerator deniña()
    {
        yield return new WaitForSeconds(0.6f);
        niña.SetActive(false);
    }
}
