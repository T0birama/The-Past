using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetInmedia : MonoBehaviour
{
    public int escena;
    // Start is called before the first frame update
    void Start()
    {
        relaodScene(escena);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void relaodScene(int esc)
    {
        SceneManager.LoadScene(esc);
    }
}
