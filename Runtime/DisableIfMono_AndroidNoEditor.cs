using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableIfMono_AndroidNoEditor : MonoBehaviour
{

    public GameObject[] m_whatToDisable;
    public GameObject[] m_whatToDestroy;

    public bool m_useAwake = true;
    public void Awake()
    {
        if (m_useAwake)
        {
            DisableIfAndroidNoEditor();
        }
    }

    private void DisableIfAndroidNoEditor()
    {
        bool isEditor = false;
#if UNITY_EDITOR         
        isEditor = true;
#endif
        bool isAndroid = Application.platform == RuntimePlatform.Android;

        if(!isEditor && isAndroid)
        {
            foreach (var item in m_whatToDisable)
            {
                item.SetActive(false);
            }
            foreach (var item in m_whatToDisable)
            {
                Destroy(item);
            }
        }
    }
}
