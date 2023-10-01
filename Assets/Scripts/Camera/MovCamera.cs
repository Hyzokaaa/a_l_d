using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamera : MonoBehaviour
{
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

	private void Start()
	{
		target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		transform.position = target.transform.position;
	}
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
/*
El método RotateCamera() calcula el ángulo de rotación en el eje X basado 
en la posición del ratón en el eje Y de la pantalla y luego interpola suavemente 
la rotación actual de la cámara hacia esa rotación.

El método MoveCamera() calcula la posición deseada de la cámara basada en la 
posición del ratón en los ejes X e Y de la pantalla y luego mueve suavemente 
la posición actual de la cámara hacia esa posición utilizando una interpolación 
suave (SmoothDamp).
target: Es una referencia al objeto que la cámara sigue. En este caso, es el jugador.

distanceY y distanceZ: Son las distancias verticales y horizontales, respectivamente, desde el objetivo hasta la cámara.

rotationLerp: Es el factor de interpolación para la rotación de la cámara.

xRotation: Es el ángulo de rotación actual de la cámara en el eje X.

rotationF1 y rotationF2: Son los factores de rotación utilizados para calcular la posición deseada de la cámara.

smoothTime: Es el tiempo que tarda la cámara en alcanzar su posición deseada desde su posición actual.
*/