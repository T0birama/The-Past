using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; 
public class niñaCorriendo : MonoBehaviour
{
    public GameObject niña;
    public PlayableDirector TimelineNiña;
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
        }
    }

    IEnumerator deniña()
    {
        yield return new WaitForSeconds(0.6f);
        niña.SetActive(false);
    }
}
