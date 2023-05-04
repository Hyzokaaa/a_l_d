using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamera : MonoBehaviour
{
    public Transform target; // referencia al jugador
    public float distanceY = 14f; // distancia entre la cámara y el jugador
    public float distanceZ = -14f;
    public float xRotation = 45f; // rotación en el eje X
    public float smoothTime = 0.125f;
    public Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {
        // Calcular la posición deseada de la cámara
        Vector3 desiredPosition = new Vector3(target.position.x, distanceY, target.position.z + distanceZ);

        // Actualizar la posición de la cámara utilizando SmoothDamp
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);

        // Actualizar la rotación de la cámara
        transform.rotation = Quaternion.Euler(xRotation, transform.eulerAngles.y, 0f);
    }
}