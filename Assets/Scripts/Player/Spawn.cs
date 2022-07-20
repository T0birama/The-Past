using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Spawn : MonoBehaviour
{
    public Transform playerTransform;
    public Transform Spawner;
    public PlayableDirector fadedBlack;
    public bool ison;
    public GameObject Texto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ison)
        {
            if (Input.GetKey(KeyCode.E))
            {
                StartCoroutine(Faded());
                fadedBlack.Play();
            }
        }
    }
    IEnumerator Faded()
    {
        yield return new WaitForSeconds(0.5f);
        playerTransform.transform.position = Spawner.transform.position;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Texto.SetActive(true);
            ison = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Texto.SetActive(false);
            ison = false;
        }
    }
}
