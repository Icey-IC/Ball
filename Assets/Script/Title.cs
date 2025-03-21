using System;
using UnityEngine;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    public GameObject MenuPart;
    public GameObject PlayPart;

    public AudioSource ButtonPress;
    public Animator BallAni;
    public GameObject Ball;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        MenuPart.transform.position = new Vector3(-5.2f,-0.5f,0);
        PlayPart.transform.position = new Vector3(-5.2f,-2.2f,0);

    }
    
    public void PlayButton()
    {
        ButtonPress.Play();
        Ball.SetActive(true);
        Ball.transform.localScale = new Vector3(0,0,0);
        BallAni.SetTrigger("Transition");
    }

    public void MenuButton()
    {
        ButtonPress.Play();
    }

    public void xButton()
    {
        ButtonPress.Play();
        Application.Quit();
    }
}
