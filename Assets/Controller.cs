using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Controller : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vbBtnObj;
    public Animator anim;
    public AudioSource sound_1;

 // Use this for initialization
    void Start () {
        vbBtnObj = GameObject.Find("girl1_btn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        anim.GetComponent<Animator>();
        sound_1 = GameObject.Find("Sound_1").GetComponent<AudioSource>();
 }
 
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        anim.Play("FreeVoxelGirl-jump",-1,0f);
        sound_1.Play();
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        anim.Play("FreeVoxelGirl-idle",-1,0f);
        Debug.Log("Button released");
    }
    
    // Update is called once per frame
    void Update () {
        
    }
}
