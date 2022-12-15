using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NormalReset : MonoBehaviour
{
    public int escena;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                relaodScene(escena);
            }
        }



    }

    public void relaodScene(int esc)
    {
        SceneManager.LoadScene(esc);
    }
}
