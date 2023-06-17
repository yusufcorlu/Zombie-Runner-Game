using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using StarterAssets;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera vcam;
    [SerializeField] FirstPersonController fpsController;
    [SerializeField] float zoomedOutFOV = 40f;
    [SerializeField] float zoomedInFOV = 25f;
    [SerializeField] float zoomedOutSensitivity = 1f;
    [SerializeField] float zoomedInSensitivity = .01f;

    bool zoomedInToggle = false;

    private void OnDisable() 
    {
        ZoomOut();
    }

    private void Update() 
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                ZoomIn();
            }

            else
            {
                ZoomOut();

            }
        }
    }

    private void ZoomIn()
    {
        zoomedInToggle = true;
        vcam.m_Lens.FieldOfView = zoomedInFOV;
        fpsController.RotationSpeed = zoomedInSensitivity;
    }

    private void ZoomOut()
    {
        zoomedInToggle = false;
        vcam.m_Lens.FieldOfView = zoomedOutFOV;
        fpsController.RotationSpeed = zoomedOutSensitivity;
    }
}
