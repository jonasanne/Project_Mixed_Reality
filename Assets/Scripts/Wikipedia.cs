using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Wikipedia : MonoBehaviour
{
	public string URL;

	public void OpenUrl()
    {
        Debug.Log("Opening Url");
        Application.OpenURL(URL);
    }
}
