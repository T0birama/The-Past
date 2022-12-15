using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Playables;

public class Enemy2 : MonoBehaviour
{
    public NavMeshAgent Enemy;
    public float TiempoDeSpeed = 5;
    public Transform player;
    public Animator Animator1;
    public AudioSource a1;

    public PlayableDirector timelinemuerte;
   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(VolverSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        //Enemy.SetDestination(player.transform.position);
        
    }

    public void PerseguirPlayer()
    {
        Animator1.SetFloat("multi", 1f);
        Enemy.SetDestination(player.transform.position);
        Enemy.acceleration = 100;
        Enemy.angularSpeed = 100;
        Enemy.speed = 30;
        a1.volume = 0.5f;
        a1.pitch = 1.5f;
        StopAllCoroutines();
       
    }

    public void StopPlayer()
    {
        Animator1.SetFloat("multi", 0f);
        Enemy.SetDestination(transform.position);
        Enemy.speed = 0;
        Enemy.acceleration = 0;
        Enemy.angularSpeed = 0;
        StartCoroutine(VolverSpeed());
        a1.volume = 1f;
        a1.pitch = 0.6f;
  
    }

    IEnumerator VolverSpeed()
    {
        yield return new WaitForSeconds(TiempoDeSpeed);
        PerseguirPlayer(); 
    }

    public void soloPaMorir()
    {
        Animator1.SetFloat("multi", 0f);
        Enemy.speed = 0;
        Enemy.acceleration = 0;
        Enemy.angularSpeed = 0;
    }
    




}
