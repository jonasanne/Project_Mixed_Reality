using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

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

    ARTrackedImageManager m_image_tracker;
    Dictionary<int, GameObject> m_spawned_worlds = new Dictionary<int, GameObject>();

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
        foreach (ARTrackedImage i in args_.added)
        {
            if (i.referenceImage.name == "h2o")
            {
                //if (Molecule2.activeSelf == true)
                //{
                //    Molecule2.SetActive(false);
                //}
                m_spawned_worlds.Add(i.GetInstanceID(), Instantiate(h2o, i.transform.position, i.transform.rotation));
                //if (Molecule1.activeSelf == false)
                //{
                //    Molecule1.SetActive(true);
                //}
            }
            else if (i.referenceImage.name == "ch2o")
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
