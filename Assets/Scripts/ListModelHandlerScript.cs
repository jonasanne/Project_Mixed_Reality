using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ListModelHandlerScript : MonoBehaviour
{
    public UnityEngine.UI.Button[] btns;
    static GameObject targetObject;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {

        if(btns == null)
        {
            Debug.LogError("No buttons");
        }

        foreach(UnityEngine.UI.Button btn in btns)
        {
            string nameMol = "";

            //children overlopen
            foreach (Transform tr in btn.transform)
            {
                //find moleculename tag
                if (tr.tag == "MoleculeName")
                {
                    nameMol = tr.name;
                }
            }
            btn.onClick.AddListener(() => TaskOnClick(nameMol));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick(string nameMol)
    {

        string pathPrefab = "prefabs/" + nameMol;
        targetObject = GameObject.Find(nameMol);
        PlayerPrefs.SetString("ChosenMolecule", nameMol);
        PlayerPrefs.SetInt("AlreadyLoaded", 0);
        //send molecule to new page
        Application.LoadLevel(sceneName);


    }

}
