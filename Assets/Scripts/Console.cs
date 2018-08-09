using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
	public GameObject inputField;
	
	private void OnEnable()
	{
		InputField field = inputField.GetComponent<InputField>();
		field.ActivateInputField();
	}

}
