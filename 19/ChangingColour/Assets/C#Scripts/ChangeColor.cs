using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour 
{
	Renderer render;
	float time = 0;
	// Use this for initialization
	void Start () 
	{
		render = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (time > 5)
		{
			time = 0;
			time = time + Time.deltaTime;
			render.material.color = Color.Lerp(Color.white, Color.red, time / 5);
		}
		time = time + Time.deltaTime;
		render.material.color = Color.Lerp (Color.red, Color.white, time / 5);
	}
}
