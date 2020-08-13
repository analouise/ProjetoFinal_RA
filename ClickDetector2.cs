using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickDetector2 : MonoBehaviour
{
    public GameObject img1;
    public GameObject img2;
    public GameObject img3;

    private bool playing;

    // Start is called before the first frame update
    void Start()
    {
        playing = false;
  
        img1.GetComponent<GameObject>();
        img2.GetComponent<GameObject>();
        img3.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        if (!playing)
        {
            img1.SetActive(true);
            img2.SetActive(true);
            img3.SetActive(true);
        }
        else
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(false);
        }

        playing = !playing;
    }
}