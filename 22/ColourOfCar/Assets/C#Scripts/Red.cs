﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Red : MonoBehaviour 
{
	public Renderer car;
	// Use this for initialization
	void Start () 
	{
		Button redButton = GetComponent<Button> ();
		redButton.onClick.AddListener (ChangeRed);
	}
	
	// Update is called once per frame
	void Update () 
	{
		

	}
	void ChangeRed()
	{
		car.material.color = Color.red;
	}

}
