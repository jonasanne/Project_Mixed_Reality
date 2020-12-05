using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Main : MonoBehaviour
{
    private string ChosenMolecule;
    private int AlreadyLoaded;// 0 or 1

    // Start is called before the first frame update
    void Start()
    {
        LoadModel();
    }

    // Update is called once per frame
    void Update()
    {


    }

    void LoadModel()
    {
        AlreadyLoaded = PlayerPrefs.GetInt("AlreadyLoaded");
        if (AlreadyLoaded == 0)
        {
            ChosenMolecule = PlayerPrefs.GetString("ChosenMolecule");
            Debug.Log(ChosenMolecule);
            if (ChosenMolecule != "")
            {
                //load molecule
                string PathToMol = "Assets/Prefab/" + ChosenMolecule + ".prefab";
                //GameObject _asset = AssetDatabase.LoadAssetAtPath(PathToMol, typeof(Object)) as GameObject;
                //GameObject MoleculeInstance = Instantiate(_asset);
            }

            AlreadyLoaded = 1;
        }
    }
}
