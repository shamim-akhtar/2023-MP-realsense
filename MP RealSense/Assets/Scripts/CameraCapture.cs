using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Intel.RealSense;

public class CameraCapture : MonoBehaviour
{
    private WebCamTexture webCamTexture;

    // Start is called before the first frame update
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;

        if (devices.Length > 1)
        {
            //Choose the Intel RealSense camera
            webCamTexture = new WebCamTexture(devices[1].name);

            //Start capturing video
            webCamTexture.Play();

            //Apply the camera feed to the Material
            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.mainTexture = webCamTexture;
            }
        }
        else
        {
            Debug.Log("No camera devices found.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
