using UnityEngine;
using System.Collections;

public class ReturnToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void OnGUI()
	{
	if(GUI.Button(new Rect(Screen.width-105,5,100,50),"Zoom Out"))
		{
		Application.LoadLevel(2);	
		}
		
	}
}
