using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirConF1 : MonoBehaviour
{
    public int scene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            ResetScene(scene);
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void ResetScene(int scn)
    {
        SceneManager.LoadScene(scn);
    }
}
