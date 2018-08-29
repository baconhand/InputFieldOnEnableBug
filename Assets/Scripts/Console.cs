using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
	//public InputField inputField;
	public TMP_InputField inputField;
	
	private void OnEnable()
	{		
		inputField.ActivateInputField();
	}
}
