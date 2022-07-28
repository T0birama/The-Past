using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Entidad1 : MonoBehaviour
{
    public GameObject puerta1Gift;
    public GameObject[] entidad1;
    public PlayableDirector timeline0;
    public PlayableDirector timeline1;
    public PlayableDirector timeline2;
    public PlayableDirector timeline3;
    public PlayableDirector timeline4;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool todosEscondidos = true;
        foreach (GameObject g in entidad1)
        {
            if (g.activeSelf)
            {
                todosEscondidos = false;
            }
        }

        puerta1Gift.SetActive(todosEscondidos);

        if (puerta1Gift.activeSelf)
        {
            this.enabled = false;
        }

        if (entidad1[0].activeSelf)
        {
            timeline0.Play();
           
        }
        else
        {
            timeline0.Stop();
        }

        if (entidad1[1].activeSelf)
        {
            timeline1.Play();
        }
        else
        {
            timeline1.Stop();
        }

        if (entidad1[2].activeSelf)
        {
            timeline2.Play();
        }
        else
        {
            timeline2.Stop();
        }

        if (entidad1[3].activeSelf)
        {
            timeline3.Play();
        }
        else
        {
            timeline3.Stop();
        }
        if (entidad1[4].activeSelf)
        {
            timeline4.Play();
        }
        else
        {
            timeline4.Stop();
        }



    }
}
