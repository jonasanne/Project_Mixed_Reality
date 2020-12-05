using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraCollider : MonoBehaviour
{
    private DataScript d;
    private Wikipedia w;

    private void OnTriggerEnter(Collider collider_)
    {
        d = GetComponent<DataScript>();
        w = GetComponent<Wikipedia>();
        Debug.Log(w.URL);
        
        var modelList = d.Models;

        if (collider_.gameObject.tag == "ARCamera")
        {
            Debug.Log("MoleculeLoaded");

            GameObject plane = GameObject.Find("Plane");
            if (plane.activeSelf == true)
            {
                plane.SetActive(false);
            }

            Model model = modelList.Find(m => m.ShortName == gameObject.tag);
            var tagname = gameObject.tag;
            
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

            
            //wikipedia link
            w.URL = model.WikipediaLink;
            //proberen met playerpref
            PlayerPrefs.SetString("WikiLink", w.URL);
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
