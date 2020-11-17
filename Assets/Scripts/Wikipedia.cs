using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Wikipedia : MonoBehaviour
{
	public Button yourButton;
	public string URL;


	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		
	}

	void TaskOnClick()
	{
		//Debug.Log("You have clicked the button!");
		Application.OpenURL(URL.ToString());
	}
}
