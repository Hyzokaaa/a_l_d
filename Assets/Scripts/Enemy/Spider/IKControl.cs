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

    // Duración de la transición en segundos
    private float transitionDuration = 0.2f;

    // Tiempo transcurrido desde el inicio de la transición
    private float transitionTime = 0f;

    // Altura máxima de la trayectoria en el eje Y
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
            // Calcular el tiempo transcurrido desde el inicio de la transición
            transitionTime += Time.fixedDeltaTime;

            // Calcular el valor de t en función del tiempo transcurrido
            float t = Mathf.Clamp01(transitionTime / transitionDuration);

            // Calcular la posición intermedia en el eje XZ
            Vector3 intermediatePosition = Vector3.Lerp(realPosition, nextPosition, t);

            // Calcular la posición intermedia en el eje Y utilizando una función parabólica
            intermediatePosition.y += maxHeight * (1 - 4 * (t - 0.5f) * (t - 0.5f));

            // Mover el objeto a la posición intermedia
            transform.position = intermediatePosition;

            // Si la transición ha terminado, actualizar la posición real y reiniciar el tiempo transcurrido
            if (t >= 1f)
            {
                realPosition = transform.position;
                transitionTime = 0f;
            }
        }
        else
        {
            // Si no hay transición en curso, mover el objeto a la posición real
            transform.position = realPosition;
        }
    }
}
