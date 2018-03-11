using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Green : MonoBehaviour 
{
	public Renderer car;
	// Use this for initialization
	void Start () 
	{
		Button greenButton = GetComponent<Button>();
		greenButton.onClick.AddListener (ChangeGreen);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void ChangeGreen()
	{
		car.material.color = Color.green;
	}
}
