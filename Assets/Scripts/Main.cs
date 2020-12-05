using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Main : MonoBehaviour
{
    private string ChosenMolecule;
    private int AlreadyLoaded;// 0 or 1

    public Camera AR_Camera;
    public ARRaycastManager raycastmanager;
    public ARPlaneManager planeManager;
    public List<ARRaycastHit> hits = new List<ARRaycastHit>();


    int CountHits = 0;

    // Start is called before the first frame update
    void Start()
    {
        LoadModel();
    }

    void LoadModel()
    {
        GameObject planeObject = GameObject.Find("Plane");
        if (planeObject.activeSelf == false)
        {
            planeObject.SetActive(true);
        }
        AlreadyLoaded = PlayerPrefs.GetInt("AlreadyLoaded");
        if (AlreadyLoaded == 0)
        {
            ChosenMolecule = PlayerPrefs.GetString("ChosenMolecule");
            Debug.Log(ChosenMolecule);
            if (ChosenMolecule != "")
            {
                //load molecule


                //GameObject MoleculeInstance = Instantiate(modelToLoad);
                Update();
            }

            AlreadyLoaded = 1;
            foreach (var plane in planeManager.trackables)
            {
                plane.gameObject.SetActive(false);
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = AR_Camera.ScreenPointToRay(Input.mousePosition);
            if (raycastmanager.Raycast(ray, hits))
            {
                if (CountHits < 1)
                {
                    string PathToMol = "Prefab/" + ChosenMolecule;
                    GameObject modelToLoad = Resources.Load(PathToMol) as GameObject;

                    Pose pose = hits[0].pose;
                    Instantiate(modelToLoad, pose.position, pose.rotation);

                }
                CountHits += 1;
                foreach (var plane in planeManager.trackables)
                {
                    plane.gameObject.SetActive(false);
                }
            }
            Debug.Log(CountHits);
        }

    }

}
