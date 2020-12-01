using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider_)
    {
        //var dataScript = GetComponent<Data>();
        //var modelList = dataScript.Models;

        if (collider_.gameObject.tag == "ARCamera")
        {
            Debug.Log(gameObject.tag); // laad tag in van de molecule

            Debug.Log("MoleculeLoaded");
            //Text myText = GameObject.Find("AR Session Origin/Canvas/Text").GetComponent<Text>();
            //myText.text = "H2OLoaded";

            Text formule = GameObject.Find("AR Session Origin/Canvas/Formule").GetComponent<Text>();
            //formule.text = modelList.Find(p => p.ShortName == );
            formule.text = "H2O";

            Text solidState = GameObject.Find("AR Session Origin/Canvas/Solid-State/Solid-State-info").GetComponent<Text>();
            solidState.text = "under 0°C";

            Text liquidState = GameObject.Find("AR Session Origin/Canvas/Liquid-State/Liquid-State-info").GetComponent<Text>();
            liquidState.text = "0 to 100°C";

            Text gasState = GameObject.Find("AR Session Origin/Canvas/Gas-State/Gas-State-info").GetComponent<Text>();
            gasState.text = "above 100°C";

            Text infoMolecule = GameObject.Find("AR Session Origin/Canvas/Info").GetComponent<Text>();
            infoMolecule.text = "Water is a polar inorganic compound that is at room temperature …";

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
