using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class spawnNav : MonoBehaviour
{
    public GameObject MeshAgent;
    public GameObject colliderdeagente;
    public PlayableDirector Luz;

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
            MeshAgent.SetActive(true);
            colliderdeagente.SetActive(true);
            Luz.Play();
        }
    }
}
