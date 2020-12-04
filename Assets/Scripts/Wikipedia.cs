using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Wikipedia : MonoBehaviour
{
	public string URL;

	public void OpenUrl()
    {
        URL = PlayerPrefs.GetString("WikiLink");
        Debug.Log("Opening Url with url:"+ URL);
        //Debug.Log(URL);
        Application.OpenURL(URL);
    }
}
