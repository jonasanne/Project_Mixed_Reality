using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

[RequireComponent(typeof(ARTrackedImageManager))]
public class MultipleTrackers : MonoBehaviour
{
    public GameObject h2o;
    public GameObject ch2o;
    public GameObject nh3;
    public GameObject co2;
    public GameObject so2;
    public GameObject ch4;
    public GameObject c2h5oh;

    private Text text;

    ARTrackedImageManager m_image_tracker;
    SortedDictionary<int, GameObject> m_spawned_worlds = new SortedDictionary<int, GameObject>();

    private void Awake()
    {
        m_image_tracker = GetComponent<ARTrackedImageManager>();
    }

    private void OnEnable()
    {
        m_image_tracker.trackedImagesChanged += OnTrackedImageChanged;
    }

    private void OnDisable()
    {
        m_image_tracker.trackedImagesChanged -= OnTrackedImageChanged;
    }

    void OnTrackedImageChanged(ARTrackedImagesChangedEventArgs args_)
    {
        Text text = GameObject.Find("AR Session Origin/Canvas/Text").GetComponent<Text>();
        
        foreach (ARTrackedImage i in args_.added)
        {
            if (m_spawned_worlds.Count < 2)
            {
                if (i.referenceImage.name == "h2o")
                {
                    m_spawned_worlds.Add(i.GetInstanceID(), Instantiate(h2o, i.transform.position, i.transform.rotation));
                }
                if (i.referenceImage.name == "ch2o")
                {
                    m_spawned_worlds.Add(i.GetInstanceID(), Instantiate(ch2o, i.transform.position, i.transform.rotation));
                }
                else if (i.referenceImage.name == "nh3")
                {
                    m_spawned_worlds.Add(i.GetInstanceID(), Instantiate(nh3, i.transform.position, i.transform.rotation));
                }
                else if (i.referenceImage.name == "co2")
                {
                    m_spawned_worlds.Add(i.GetInstanceID(), Instantiate(co2, i.transform.position, i.transform.rotation));
                }
                else if (i.referenceImage.name == "so2")
                {
                    m_spawned_worlds.Add(i.GetInstanceID(), Instantiate(so2, i.transform.position, i.transform.rotation));
                }
                else if (i.referenceImage.name == "ch4")
                {
                    m_spawned_worlds.Add(i.GetInstanceID(), Instantiate(ch4, i.transform.position, i.transform.rotation));
                }
                else if (i.referenceImage.name == "c2h5oh")
                {
                    m_spawned_worlds.Add(i.GetInstanceID(), Instantiate(c2h5oh, i.transform.position, i.transform.rotation));
                }
            }
            
            if (m_spawned_worlds.Count == 2)
            {
                //text.text = m_spawned_worlds[i.GetInstanceID()].ToString();
                text.text = m_spawned_worlds.Last().ToString();
                Object.Destroy(m_spawned_worlds[1]);
                m_spawned_worlds.Remove(1);
                args_.added.Clear();
                ARTrackedImageManager m_image_tracker;
                m_image_tracker = GetComponent<ARTrackedImageManager>();
                OnEnable();
            }
        }
        
        

        foreach (ARTrackedImage i in args_.updated)
        {
            int id = i.GetInstanceID();
            if (m_spawned_worlds.ContainsKey(id))
            {
                m_spawned_worlds[id].transform.position = i.transform.position;
                m_spawned_worlds[id].transform.rotation = i.transform.rotation;
            }
        }

        foreach (ARTrackedImage i in args_.removed)
        {
            int id = i.GetInstanceID();
            if (m_spawned_worlds.ContainsKey(id))
            {
                Object.Destroy(m_spawned_worlds[id]);
                m_spawned_worlds.Remove(id);
            }
        }

    }
}
