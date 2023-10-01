using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKControl : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    private Vector3 realPosition;
    [SerializeField]
    private Vector3 nextPosition;
    [SerializeField]
    private float distance = 1f;

    // Duraci�n de la transici�n en segundos
    private float transitionDuration = 0.2f;

    // Tiempo transcurrido desde el inicio de la transici�n
    private float transitionTime = 0f;

    // Altura m�xima de la trayectoria en el eje Y
    private float maxHeight = 1f;

    void Start()
    {
        realPosition = transform.position;
        distance = Random.Range(0.2f, 1.2f);
    }

    void FixedUpdate()
    {
        nextPosition = target.position;
        if (Vector3.Distance(realPosition, nextPosition) > distance)
        {
            // Calcular el tiempo transcurrido desde el inicio de la transici�n
            transitionTime += Time.fixedDeltaTime;

            // Calcular el valor de t en funci�n del tiempo transcurrido
            float t = Mathf.Clamp01(transitionTime / transitionDuration);

            // Calcular la posici�n intermedia en el eje XZ
            Vector3 intermediatePosition = Vector3.Lerp(realPosition, nextPosition, t);

            // Calcular la posici�n intermedia en el eje Y utilizando una funci�n parab�lica
            intermediatePosition.y += maxHeight * (1 - 4 * (t - 0.5f) * (t - 0.5f));

            // Mover el objeto a la posici�n intermedia
            transform.position = intermediatePosition;

            // Si la transici�n ha terminado, actualizar la posici�n real y reiniciar el tiempo transcurrido
            if (t >= 1f)
            {
                realPosition = transform.position;
                transitionTime = 0f;
            }
        }
        else
        {
            // Si no hay transici�n en curso, mover el objeto a la posici�n real
            transform.position = realPosition;
        }
    }
}
