using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy2 : MonoBehaviour
{
    public NavMeshAgent Enemy;
    public float TiempoDeSpeed = 5;
    public Transform player;
    public Animator Animator1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(VolverSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        Enemy.SetDestination(player.transform.position);
        
    }

    public void PerseguirPlayer()
    {
        Animator1.SetFloat("multi", 1f);
        Enemy.SetDestination(player.transform.position);
        Enemy.enabled = true;
        Enemy.speed = 30;

    }

    public void StopPlayer()
    {
        Animator1.SetFloat("multi", 0f);
        Enemy.speed = 0;
        Enemy.enabled = false;
        StartCoroutine(VolverSpeed());
    }

    IEnumerator VolverSpeed()
    {
        yield return new WaitForSeconds(TiempoDeSpeed);
        PerseguirPlayer(); 
    }

    


}
