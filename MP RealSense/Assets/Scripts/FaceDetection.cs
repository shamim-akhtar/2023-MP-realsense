using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Intel.RealSense;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ObjdetectModule;
using OpenCVForUnity.UnityUtils;

public class FaceDetection : MonoBehaviour
{
    private CascadeClassifier cascade;
    private Mat grayMat;
    private MatOfRect faces;
    CameraCapture cameraCapture;

    // Start is called before the first frame update
    void Start()
    {
        cascade = new CascadeClassifier();
        cascade.load(Utils.getFilePath("haarcascade_frontalface_alt.xml"));

        grayMat = new Mat();
        faces = new MatOfRect();
    }

    // Update is called once per frame
    void Update()
    {
        //Convert camera texture to grayscale Mat
        Mat cameraFeedMat = new Mat();
    }
}
