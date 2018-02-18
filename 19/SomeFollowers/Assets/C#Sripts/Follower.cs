using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour 
{
	 
	public Transform[] objects;
	float time = 0;
	float min = 1000;
	Transform nearestObj;
	// Use this for initialization
	void Start () 
	{
		for(int n = 0; n < objects.Length; n++)
		{
			float dist = Vector3.Distance(objects[n].position, transform.position);
			if(dist < min)
			{
				min = dist;
				nearestObj = objects [n];
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 direction = nearestObj.position - transform.position;
		direction.Normalize ();
		transform.Translate(direction * Time.deltaTime);
	
	}
}
