using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetector3 : MonoBehaviour
{
    public GameObject tex;

    private bool playing;

    // Start is called before the first frame update
    void Start()
    {
        playing = false;
        tex.GetComponent<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown() //É chamado após o clique
    {
        if (!playing)
        {
            tex.SetActive(true); //Ativa o texto
        }
        else
        {
            tex.SetActive(false); //Desativa a exibição do texto
        }
        playing = !playing;
    }
}
