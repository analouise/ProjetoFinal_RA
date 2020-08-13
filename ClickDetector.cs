using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    public Animator ani;
    public GameObject tex;
    public Animator ani2;
    public GameObject tex2;
    public Animator ani4;
    public GameObject tex4;


    private bool playing1;
    private bool playing2;
    private bool playing4;


    // Start is called before the first frame update
    void Start()
    {
        playing1 = false;
        playing2 = false;

        playing4 = false;

        ani.GetComponent<Animator>();
        tex.GetComponent<GameObject>();

        ani2.GetComponent<Animator>();
        tex2.GetComponent<GameObject>();

        ani4.GetComponent<Animator>();
        tex4.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() //É chamado após o click
    {
        if (!playing1)
        {
            ani.Play("esporos"); //Muda o estado para esporos
            tex.SetActive(true); //Ativa o texto 

        }
        else
        {
            ani.Play("None"); //Volta para o estado normal (parando a animação)
            tex.SetActive(false); //Desativa o texto esporos

        }

        playing1 = !playing1;

        if (!playing2)
        {
            ani2.Play("filoide"); //Muda o estado para filoide
            tex2.SetActive(true); //Ativa o texto filoide
        }
        else
        {
            ani2.Play("None"); //Volta para o estado normal (parando a animação)
            tex2.SetActive(false); //Desativa o texto filoide
        }

        playing2 = !playing2;

        if (!playing4)
        {
            ani4.Play("rizoide"); //Muda o estado para rizoide
            tex4.SetActive(true); //Ativa o texto rizoide
        }
        else
        {
            ani4.Play("None"); //Volta para o estado normal (parando a animação)
            tex4.SetActive(false); //Desativa o texto rizoide
        }

        playing4 = !playing4;


    }

}
