﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SphereBtnScript : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vbBtnObj;
    public Animator anim;

 // Use this for initialization
    void Start () {
        vbBtnObj = GameObject.Find("sphere_btn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        anim.GetComponent<Animator>();
 }
 
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        anim.Play("sphere_animation");
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        anim.Play("none");
        Debug.Log("Button released");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
