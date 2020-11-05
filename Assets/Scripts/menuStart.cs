using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuStart : MonoBehaviour
{
    public void changeInformationScene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
