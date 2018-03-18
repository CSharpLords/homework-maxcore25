using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour 
{
	
	public Text scoreField;
	public static int score = 0;
	// Use this for initialization
	void Start () 
	{
		Button plusPoint = GetComponent<Button> ();
		plusPoint.onClick.AddListener (Increase);
		scoreField.text = "0";
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	void Increase()
	{
		score = score + 1;
		scoreField.text = score.ToString ();
	}
}
