using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour {
	public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		anim = GetComponent<Animator>();

		
		
	}

	public void ColourActions(string ActionCommands)
	{
		ActionCommands = ActionCommands.Trim();
        switch (ActionCommands)
		{
           case "blue":
		    gameObject.GetComponent<Renderer>().material.color = Color.blue;
		    break;
		   case "green":
		    gameObject.GetComponent<Renderer>().material.color = Color.green;
		    break;
		   case "white":
		    gameObject.GetComponent<Renderer>().material.color = Color.white;
		    break;
		   case "gray":
		    gameObject.GetComponent<Renderer>().material.color = Color.gray;
		    break;
		   case "yellow":
		    gameObject.GetComponent<Renderer>().material.color = Color.yellow;
		    transform.Rotate(Vector3.up, 10f * Time.deltaTime);
		    break;
		   case "black":
		    gameObject.GetComponent<Renderer>().material.color = Color.black;
		    break;

		}
	}


	public void AnimActions(string ActionCommands)
	{
		ActionCommands = ActionCommands.Trim();
        switch (ActionCommands)
		{
          case "hello":
		   anim.Play("cube_animation");
		   break;
		  case "hi":
		   anim.Play("cylinder_animation");
		   break;
		  case "Hey":
		    anim.Play("sphere_animation");
		   break;
		  

		}
}
}
