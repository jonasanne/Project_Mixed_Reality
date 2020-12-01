using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelClicker : MonoBehaviour
{

    public GameObject gameObject;
    public GameObject[] gameObjectsWithTags;

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
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

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
    }
}
