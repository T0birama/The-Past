using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.AI;

public class Pause : MonoBehaviour
{
    public GameObject ImagePause;
    public MouseLook mouse;
    public PlayerMovement player;
    public PlayableDirector TimelineNarrativa;
    public NavMeshAgent agent;
    public TimerEntidades timer;
    public Rigidbody rbplayer;
    public CharacterController chplayer;
    public LuzReduction lantern;
    public Locura locura;

    bool esta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            esta = !esta;
            if (esta)
            {
                mouse.mouseSensivility = 0;
                ImagePause.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                player.speed = 0;
                TimelineNarrativa.Pause();
                timer.Pausar();
                agent.speed = 0;
                rbplayer.angularDrag = 1000;
                rbplayer.drag = 1000;
                rbplayer.mass = 100;
                chplayer.enabled = false;
                lantern.reduction=0;
                locura.enabled = false;
                

            }
            else
            {

                mouse.mouseSensivility = 200;
                ImagePause.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                player.speed =5;
                TimelineNarrativa.Resume();
                timer.Continuar();
                agent.speed = 2;
                rbplayer.angularDrag = 1;
                rbplayer.drag = 1;
                chplayer.enabled = true;
                rbplayer.mass = 1;
                lantern.reduction = 20;
                locura.enabled = true;


            }

        }
    }
}
