using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Intel.RealSense;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ImgprocModule;
using OpenCVForUnity.ObjdetectModule;
using OpenCVForUnity.UnityUtils;

public class FaceDetection : MonoBehaviour
{
    private CascadeClassifier cascade;
    private Mat grayMat;
    private MatOfRect faces;
    private Mat cameraTextureMat;
    CameraCapture cameraCapture;

    // Start is called before the first frame update
    void Start()
    {
        cameraCapture = GetComponent<CameraCapture>();

        cascade = new CascadeClassifier();
        cascade.load(Utils.getFilePath("haarcascade_frontalface_alt.xml"));

        grayMat = new Mat();
        faces = new MatOfRect();
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraCapture.webCamTexture.isPlaying)
        {
            //Convert camera texture to Mat
            Utils.webCamTextureToMat(cameraCapture.webCamTexture, grayMat);

            // Initialize cameraTextureMat with the same size as grayMat
            if (cameraTextureMat == null || cameraTextureMat.width() != grayMat.width() || cameraTextureMat.height() != grayMat.height())
            {
                cameraTextureMat = new Mat(grayMat.rows(), grayMat.cols(), CvType.CV_8UC4); // Change CvType as needed
            }

            //Perform face detection
            cascade.detectMultiScale(grayMat, faces, 1.1, 2, 0, new Size(30, 30));

            //Draw rectangles around detected faces
            foreach (OpenCVForUnity.CoreModule.Rect rect in faces.toArray())
            {
                Imgproc.rectangle(cameraTextureMat, rect.tl(), rect.br(), new Scalar(255, 0, 0));
            }
        }
        else
        {
            Debug.Log("cameraTexture is null");
        }
    }
}
