using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider_)
    {
        if (collider_.gameObject.tag == "ARCamera")
        {
            Debug.Log("H2Oloaded");
            Text myText = GameObject.Find("AR Session Origin/Canvas/Text").GetComponent<Text>();
            myText.text = "H2OLoaded";
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("H2Oremoved");
    }
}
