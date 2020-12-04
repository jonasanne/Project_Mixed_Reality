using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private string ChosenMolecule;

    // Start is called before the first frame update
    void Start()
    {


        ChosenMolecule = PlayerPrefs.GetString("ChosenMolecule");
        Debug.Log(ChosenMolecule);
        if(ChosenMolecule != "")
        {
            //load molecule
            string PathToMol = "Prefabs/" + ChosenMolecule;
            GameObject Molecule = (GameObject)Resources.Load(PathToMol);
            Debug.Log(Molecule);
            //GameObject MoleculeInstance = Instantiate(Molecule);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
