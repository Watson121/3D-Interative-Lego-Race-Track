using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMenu : MonoBehaviour {

    GameObject cam1, cam2, cam3, cam4, thirdPersonCam, drivingCam;


    // Use this for initialization
    void Start() {

        cam1 = GameObject.Find("Camera1");
        cam2 = GameObject.Find("Camera2");
        cam3 = GameObject.Find("Camera3");
        cam4 = GameObject.Find("Camera4");
        thirdPersonCam = GameObject.Find("Main Camera");
        drivingCam = GameObject.Find("Car Camera");

        thirdPersonCam.SetActive(true);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        drivingCam.SetActive(false);
    }

    public void Camera1() {
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        thirdPersonCam.SetActive(false);
        drivingCam.SetActive(false);
    }

    public void Camera2()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
        cam3.SetActive(false);
        cam4.SetActive(false);
        thirdPersonCam.SetActive(false);
        drivingCam.SetActive(false);
    }

    public void Camera3()
    {
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(true);
        cam4.SetActive(false);
        thirdPersonCam.SetActive(false);
        drivingCam.SetActive(false);
    }

    public void Camera4()
    {
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(true);
        thirdPersonCam.SetActive(false);
        drivingCam.SetActive(false);
    }

    public void ThirdPersonCamera()
    {
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        thirdPersonCam.SetActive(true);
        drivingCam.SetActive(false);
    }

    public void CarCamera()
    {
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        thirdPersonCam.SetActive(false);
        drivingCam.SetActive(true);
    }

}
