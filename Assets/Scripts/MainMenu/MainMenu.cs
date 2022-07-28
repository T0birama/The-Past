using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
public class MainMenu : MonoBehaviour
{
    public int scena;
    public PlayableDirector fadedBlack;
   
    public void Play()
    {
        StartCoroutine(Faded());
        fadedBlack.Play();
    }

    IEnumerator Faded()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(scena);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
