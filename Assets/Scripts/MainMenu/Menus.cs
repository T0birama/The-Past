using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; 
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public PlayableDirector FADED;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void salirPaMenu()
    {
        FADED.Play();
        StartCoroutine(salir());
    }

    IEnumerator salir()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}
