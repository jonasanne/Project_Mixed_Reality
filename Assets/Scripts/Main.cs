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
                string PathToMol = "Prefab/" + ChosenMolecule;
                GameObject modelToLoad = Resources.Load(PathToMol) as GameObject;

                GameObject MoleculeInstance = Instantiate(modelToLoad);

            }

            AlreadyLoaded = 1;
        }
    }
}
