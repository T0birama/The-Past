using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntrarYdesactivarTimer : MonoBehaviour
{
    public GameObject objeto;
    public float Timer = 5f;
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
            objeto.SetActive(true);
            StartCoroutine(TimerDeDesactivada());
        }
    }

    IEnumerator TimerDeDesactivada()
    {
        yield return new WaitForSeconds(Timer);
        objeto.SetActive(false);
        gameObject.SetActive(false);
    }
}
