using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    public int escena;
    public CharacterController pj;
    public MouseLook ms;
   
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

        pj.enabled = false;
        ms.enabled = false;

       
        
    }

    public void relaodScene(int esc)
    {
        SceneManager.LoadScene(esc);
    }
}
