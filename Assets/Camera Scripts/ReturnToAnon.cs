using UnityEngine;
using System.Collections;

public class ReturnToAnon : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void OnGUI()
	{
	if(GUI.Button(new Rect(Screen.width-1000,80,100,50),"Level Zero"))
		{
		Application.LoadLevel(0);	
		}
	if(GUI.Button(new Rect(Screen.width-1000,130,100,50),"Level One"))
		{
		Application.LoadLevel(1);	
		}
	if(GUI.Button(new Rect(Screen.width-1000,170,100,50),"Level Two"))
		{
		Application.LoadLevel(2);	
		}
	if(GUI.Button(new Rect(Screen.width-1000,220,100,50),"Level Three"))
		{
		Application.LoadLevel(3);	
		}
	}
}
