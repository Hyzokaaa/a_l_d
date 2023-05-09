using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamera : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [Header("Movement")]
    [SerializeField]
    private float distanceY;
    [SerializeField]
    private float distanceZ;
    [SerializeField]
    private float rotationLerp;
    private Vector3 velocity = Vector3.zero;
    private float xRotation;


    [Header("Rotacion")]
    [SerializeField]
    private float rotationF1;
    [SerializeField]
    private float rotationF2;
    [SerializeField]
    private float smoothTime;
    private Vector3 desiredPosition = Vector3.zero;


    void FixedUpdate()
    {
        MoveCamera();
        RotateCamera();
    }

    private void RotateCamera()
    {
        Vector2 mousePosition = Input.mousePosition;
        float min = Screen.height / 2;
        float max = 0;
        float positionLerp = Mathf.InverseLerp(min, max, mousePosition.y);
        float rotationMin = 52;
        float rotationMax = 60;

        if (mousePosition.y < Screen.height / 2)
        {
            xRotation = Mathf.Lerp(rotationMin, rotationMax, positionLerp);
        }
        Quaternion currentRotation = Quaternion.Euler(xRotation, transform.eulerAngles.y, 0f);
        transform.rotation = Quaternion.Lerp(transform.rotation, currentRotation, rotationLerp);

    }

    private void MoveCamera()
    {
        Vector2 mousePosition = Input.mousePosition;
        float screenWidthThird = Screen.width / 3;

        if (mousePosition.y < Screen.height / 2)
        {
            if (mousePosition.x < screenWidthThird)
            {
                desiredPosition = new Vector3(target.position.x - rotationF1, distanceY, target.position.z + distanceZ + rotationF2);
            }
            else if (mousePosition.x > screenWidthThird * 2)
            {
                desiredPosition = new Vector3(target.position.x + rotationF1, distanceY, target.position.z + distanceZ + rotationF2);
            }
            else
            {
                desiredPosition = new Vector3(target.position.x, distanceY, target.position.z + distanceZ );
            }
        }
        else if (mousePosition.y > Screen.height / 2)
        {
            float rotation1 = rotationF1 / 3.4f;
            float rotation2 = rotationF2 / 3.4f;
            if (mousePosition.x < screenWidthThird)
            {
                desiredPosition = new Vector3(target.position.x - rotation1, distanceY, target.position.z + distanceZ + rotation2);
            }
            else if(mousePosition.x > screenWidthThird * 2)
            {
                desiredPosition = new Vector3(target.position.x + rotation1, distanceY, target.position.z + distanceZ + rotation2);
            }
            else
            {
                desiredPosition = new Vector3(target.position.x, distanceY, target.position.z + distanceZ);
            }
        }
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);
    }

}