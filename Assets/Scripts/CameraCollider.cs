using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraCollider : MonoBehaviour
{
    public DataScript d;
    private void OnTriggerEnter(Collider collider_)
    {
        d = GetComponent<DataScript>();
        var modelList = d.Models;
        //Debug.Log(d);
        //Debug.Log(d.Models);
        //foreach (Model i in modelList)
        //{
        //    Debug.Log(i.ShortName);
        //}

        //Debug.Log(modelList.Find(m => m.ShortName == "H2O").Name);

        //Debug.Log(modelList);

        if (collider_.gameObject.tag == "ARCamera")
        {

            Model model = modelList.Find(m => m.ShortName == gameObject.tag);
            //Debug.Log(gameObject.tag); // laad tag in van de molecule
            var tagname = gameObject.tag;


            Debug.Log("MoleculeLoaded");
            //Text myText = GameObject.Find("AR Session Origin/Canvas/Text").GetComponent<Text>();
            //myText.text = "H2OLoaded";

            Text formule = GameObject.Find("AR Session Origin/Canvas/Formule").GetComponent<Text>();
            formule.text = model.ShortName;

            Text solidState = GameObject.Find("AR Session Origin/Canvas/Solid-State/Solid-State-info").GetComponent<Text>();
            solidState.text = model.Solid;

            Text liquidState = GameObject.Find("AR Session Origin/Canvas/Liquid-State/Liquid-State-info").GetComponent<Text>();
            liquidState.text = model.Liquid;

            Text gasState = GameObject.Find("AR Session Origin/Canvas/Gas-State/Gas-State-info").GetComponent<Text>();
            gasState.text = model.Gas;

            Text infoMolecule = GameObject.Find("AR Session Origin/Canvas/Info").GetComponent<Text>();
            infoMolecule.text = model.Description.Substring(0,90) + "...";

            //WikiLink = "https://en.wikipedia.org/wiki/Water";
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("MoleculeRemoved");
        Text formule = GameObject.Find("AR Session Origin/Canvas/Formule").GetComponent<Text>();
        formule.text = "Formule";

        Text solidState = GameObject.Find("AR Session Origin/Canvas/Solid-State/Solid-State-info").GetComponent<Text>();
        solidState.text = "?";

        Text liquidState = GameObject.Find("AR Session Origin/Canvas/Liquid-State/Liquid-State-info").GetComponent<Text>();
        liquidState.text = "?";

        Text gasState = GameObject.Find("AR Session Origin/Canvas/Gas-State/Gas-State-info").GetComponent<Text>();
        gasState.text = "?";

        Text infoMolecule = GameObject.Find("AR Session Origin/Canvas/Info").GetComponent<Text>();
        infoMolecule.text = "?";
    }
}
