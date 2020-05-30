using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private Camera FPSCamera;

    private bool mainCameraON = true;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        FPSCamera.enabled = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C) && mainCameraON == true)
        {
            mainCamera.enabled = false;
            FPSCamera.enabled = true;

            mainCameraON = false;

        }
        
        else if (Input.GetKeyDown(KeyCode.C) && mainCameraON == false)
        {
            mainCamera.enabled = true;
            FPSCamera.enabled = false;

            mainCameraON = true;

        }

    }
}
