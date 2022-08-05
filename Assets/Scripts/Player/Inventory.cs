using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using TMPro;

public class Inventory : MonoBehaviour
{
    public GameObject Canvas;
    public PlayableDirector TimelineApagando;
    public PlayableDirector TimelinePrendio;
    public MouseLook mouse;

    public TextMeshProUGUI TextoParaBaterias;
    
    public float Baterias;
    public GameObject CanvasImageBateria;
    public LuzReduction lu;

    public GameObject CanvasImageMedic;

    public TextMeshProUGUI TextoMedicamento;
    

    public Locura loc;

    public float medicamentoCount;


    private void Start()
    {
        
    }

    private void Update()
    {
        TextoParaBaterias.text = Baterias.ToString("0");
        TextoMedicamento.text = medicamentoCount.ToString("0");

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            mouse.mouseSensivility = 0;
            TimelinePrendio.Play();
            TimelineApagando.Stop();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        } 
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            mouse.mouseSensivility = 200;
            TimelineApagando.Play();
            TimelinePrendio.Stop();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

        }

        if(Baterias == 0)
        {
            
            CanvasImageBateria.SetActive(false);
            
        } 
        else if(Baterias >= 1)
        {
           
            CanvasImageBateria.SetActive(true);
        }

        if (medicamentoCount == 0)
        {
            
            CanvasImageMedic.SetActive(false);
        }
        else if (medicamentoCount >= 1)
        {
            
            CanvasImageMedic.SetActive(true);
        }

    }

    public void RecargarBateria()
    {
        if (lu.linterna.enabled == false)
        {
            lu.linterna.enabled = true;
        }
        lu.linterna.intensity = 1772.727f;

        Baterias -= 1;

    }

    public void recuperarCordura()
    {
        loc.cordura = 1f;
        loc.volume.weight = 0f;
        medicamentoCount -= 1;
    }






}
