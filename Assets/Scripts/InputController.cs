using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class InputController : MonoBehaviour
{

    public GameObject AR_object;
    public Camera AR_Camera;
    public ARRaycastManager raycastmanager;
    public ARPlaneManager planeManager;
    public List<ARRaycastHit> hits = new List<ARRaycastHit>();


    int CountHits = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = AR_Camera.ScreenPointToRay(Input.mousePosition);
            if(raycastmanager.Raycast(ray, hits))
            {
                if(CountHits < 1) 
                {
                    //Main mainScript = modelToLoad.GetComponent<Main>();
                    Pose pose = hits[0].pose;
                    Instantiate(AR_object, pose.position, pose.rotation);
                    
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
