using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoyTexto : MonoBehaviour
{
    public GameObject TextoDeObjeto;
    public bool EstaEnObjeto;
    public float tiempo = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EstaEnObjeto)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                TextoDeObjeto.SetActive(true);
                StartCoroutine(TiempoDeTexto());
            }
        }
    }

    IEnumerator TiempoDeTexto()
    {
        yield return new WaitForSeconds(tiempo);
        TextoDeObjeto.SetActive(false);
    }
}
