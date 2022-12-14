using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class MuertePlayer : MonoBehaviour
{
    public PlayableDirector timelineMuerte;
    public int scene;
    public float timeFor = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScene(int esc)
    {
        SceneManager.LoadScene(esc);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timelineMuerte.Play();
            StartCoroutine(TimeResetScene());
        }
    }

    IEnumerator TimeResetScene()
    {
        yield return new WaitForSeconds(timeFor);
        ResetScene(scene);
    }
}
