using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour 
{
	float time = 0;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		time = time + Time.deltaTime;
		int seconds = (int)time;
		transform.Rotate(new Vector3(0, 6, 0) * Time.deltaTime);

		if (seconds >= 10) 
		{
			print (seconds);
		}
	}
}
