using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class MatarPlayer : MonoBehaviour
{
    
    public PlayerMovement Player;
    public Locura loc;
    public PlayableDirector timelineMuerte;
    public PlayableDirector FADED;
    public Transform parquePuertaTransform;
    public Transform PlayerTransform; 
    public GameObject imagenMuerte;
    public MouseLook mouse;
    public PlayableDirector botonesSaliendo;
    public GameObject botonesMuerte;
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            loc.cordura = 0;
            loc.volume.weight = 1;
            timelineMuerte.Play();
            Player.speed = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            mouse.lockMouse = true;
            botonesSaliendo.Play();
            botonesMuerte.SetActive(true);
            imagenMuerte.SetActive(true);
        }
    }

    IEnumerator MuerteFaded()
    {
        yield return new WaitForSeconds(0.4f);
        loc.cordura = 0.5f;
        loc.volume.weight = 0.5f;
        PlayerTransform.transform.position = parquePuertaTransform.transform.position;
    }

    public void EmpezarCorrutina()
    {
        FADED.Play();
        StartCoroutine(MuerteFaded());
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        mouse.lockMouse = false;
        botonesSaliendo.Stop();
        timelineMuerte.Stop();
        imagenMuerte.SetActive(false);
        botonesMuerte.SetActive(false);
    }

    

    
}
