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
    private Texture2D cameraTexture2D;
    public Material cameraTexture;

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
        //Convert camera texture to Mat
        cameraTextureMat = new Mat(cameraTexture.mainTexture.height, cameraTexture.mainTexture.width, CvType.CV_8UC4);
        Utils.textureToTexture2D(cameraTexture.mainTexture, cameraTexture2D);
        Utils.texture2DToMat(cameraTexture2D, cameraTextureMat);

        //Convert camera texture to grayscale Mat
        Imgproc.cvtColor(cameraTextureMat, grayMat, Imgproc.COLOR_RGBA2GRAY);

        //Perform face detection
        cascade.detectMultiScale(grayMat, faces, 1.1, 2, 0, new Size(30, 30));

        //Draw rectangles around detected faces
        foreach (OpenCVForUnity.CoreModule.Rect rect in faces.toArray())
        {
            Imgproc.rectangle(cameraTextureMat, rect.tl(), rect.br(), new Scalar(255, 0, 0));
        }
    }
}
