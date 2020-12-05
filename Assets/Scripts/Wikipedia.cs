using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Wikipedia : MonoBehaviour
{
	public string URL;

    public void OnClicked(Button button)
    {
        Debug.Log(button.name);
    }


    public void OpenUrl()
    {
        URL = PlayerPrefs.GetString("WikiLink");
        if(URL != "")
        {
            Debug.Log("Opening Url with url:"+ URL);
            Application.OpenURL(URL);
        }
        else
        {

            Debug.LogError("No Url");
        }
    }
}
