using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardListener : MonoBehaviour
{
	public GameObject console;
	
	void Update ()
	{
		if(Input.GetKeyUp(KeyCode.BackQuote))
		{
			ToggleConsole();
		}		
	}

	private void ToggleConsole()
	{
		console.SetActive(!console.activeSelf);
	}
}
