using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour 
{
	public Transform follower; 
	public Transform target;
	float time = 0; 
	// Use this for initialization
	void Start () 
	{
		
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		time = 0 + Time.deltaTime;
		transform.Translate(Vector3.left * Time.deltaTime);

		Vector3 direction  = target.position - follower.position;
		direction.Normalize();
	}
}
