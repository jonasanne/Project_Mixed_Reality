using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelClicker : MonoBehaviour
{

    //public GameObject gameObject;
    private GameObject[] gameObjectsWithTags;
    private AtomDataScript datascript;
    private Wikipedia wiki;

    // Start is called before the first frame update
    void Start()
    {
        gameObjectsWithTags = GameObject.FindGameObjectsWithTag("Atom");        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;
            Ray ray = Camera.allCameras[0].ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null)
                {
                    PrintName(hit.transform.gameObject);
                }
            }
        }
    }
    private void PrintName(GameObject go)
    {
        Debug.Log(go.name);
        GameObject canvas = gameObject.transform.Find("Canvas").gameObject;
        GameObject canvasAtom = gameObject.transform.Find("CanvasAtom").gameObject;

        if (canvas.activeSelf == true)
        {
            canvas.SetActive(false);
        }

        canvasAtom.SetActive(true);

        datascript = GetComponent<AtomDataScript>();
        wiki = GetComponent<Wikipedia>();
        var modelList = datascript.Atoms;

        //Text text = GameObject.Find("AR Session Origin/Canvas/Text").GetComponent<Text>();
        //text.text = go.name;

        Atom model = modelList.Find(m => m.ShortName == go.name);
        //var tagname = gameObject.tag;

        Text atom = GameObject.Find("AR Session Origin/CanvasAtom/Atominfo/Atom").GetComponent<Text>();
        atom.text = model.ShortName;

        Text title = GameObject.Find("AR Session Origin/CanvasAtom/Atominfo/Title").GetComponent<Text>();
        title.text = model.Name;

        Text weight = GameObject.Find("AR Session Origin/CanvasAtom/Atominfo/Weight").GetComponent<Text>();
        weight.text = model.Weight;

        Text number = GameObject.Find("AR Session Origin/CanvasAtom/Atominfo/Number").GetComponent<Text>();
        number.text = model.Number;

        Text infoAtom = GameObject.Find("AR Session Origin/CanvasAtom/AtomInfoFull").GetComponent<Text>();
        infoAtom.text = model.Description.Substring(0, 90) + "...";

        //wikipedia link
        wiki.URL = model.WikipediaLink;
        //proberen met playerpref
        PlayerPrefs.SetString("WikiLink", wiki.URL);
    }

    public void ReturnToMolecule()
    {
        GameObject canvas = gameObject.transform.Find("Canvas").gameObject;
        GameObject canvasAtom = gameObject.transform.Find("CanvasAtom").gameObject;
        if (canvas.activeSelf == false)
        {
            canvasAtom.SetActive(false);
            canvas.SetActive(true);
        }

    }

}
