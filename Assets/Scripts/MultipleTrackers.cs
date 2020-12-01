﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARTrackedImageManager))]
public class MultipleTrackers : MonoBehaviour
{
    public GameObject Molecule1;
    public GameObject Molecule2;

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
                if (Molecule2.activeSelf)
                {
                    Destroy(Molecule2);
                }
                m_spawned_worlds.Add(i.GetInstanceID(), Instantiate(Molecule1, i.transform.position, i.transform.rotation));
            }
            else if (i.referenceImage.name == "ch2o")
            {
                if (Molecule1.activeSelf)
                {
                    Destroy(Molecule1);
                }
                m_spawned_worlds.Add(i.GetInstanceID(), Instantiate(Molecule2, i.transform.position, i.transform.rotation));
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
