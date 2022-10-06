using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
public class CambioDeEscena : MonoBehaviour
{
    public int scena;
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
                Texto.SetActive(false);
            }
        }

    }
    IEnumerator Faded()
    {
        yield return new WaitForSeconds(0.4f);
        Cambiodeescena(scena);
    }

    public void Cambiodeescena(int esc)
    {

        SceneManager.LoadScene(esc); 

    
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
