using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    private static GameObject instance;

    private void Awake()
    {
        if (instance == null)
        {
            // If no instance exists, this is the first one; don't destroy it.
            instance = gameObject;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // An instance already exists, destroy this one.
            Destroy(gameObject);
        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
