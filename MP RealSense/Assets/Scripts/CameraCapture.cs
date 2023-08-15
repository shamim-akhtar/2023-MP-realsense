using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Intel.RealSense;

public class CameraCapture : MonoBehaviour
{
    [HideInInspector]
    public WebCamTexture webCamTexture;

    // Start is called before the first frame update
    void Awake()
    {
        WebCamDevice[] devices = WebCamTexture.devices;

        if (devices.Length >= 1)
        {
            //Choose the Intel RealSense camera
            webCamTexture = new WebCamTexture(devices[0].name);

            //Start capturing video
            webCamTexture.Play();

            Renderer renderer = GetComponent<Renderer>();
            //Apply the camera feed to the Material
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
}
