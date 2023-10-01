using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movimiento")]
    [SerializeField]
    private float walk_speed;
    [SerializeField]
    private float back_speed;
    [SerializeField]
    private float run_speed;
    [SerializeField]
    private float rotation_speed;
    private Rigidbody rb;
    private AnimatorController animatorController;
    private Vector3 lastPosition;

    private void Start()
    {
        initializateStart();
    }
    void FixedUpdate()
    {
        move();
    }
    public void move()
    {
        float axisHorizontal = Input.GetAxisRaw("Horizontal");
        float axisVertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(axisHorizontal, 0f, axisVertical).normalized;
        float currentSpeed = walk_speed;

        if (axisHorizontal == 0 && axisVertical == 0)
        {
            animatorController.Idle();

            if (Input.GetKey(KeyCode.Mouse1))
            {
                RotateToMouse();
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                Debug.Log("estas presionando click derecho, ahora deberias moverte mas lento y rotar en" +
                    " direccion a la posicion del mouse en pantalla");
                RotateToMouse();
                UpdateDirection(direction);
                currentSpeed = back_speed;
            }
            else if (Input.GetKey(KeyCode.LeftShift) && !(Input.GetKey(KeyCode.Mouse1)))
            {    
                currentSpeed = run_speed;
                animatorController.Run();
                RotateToMovement(direction);
            }
            else
            {
                animatorController.Walk();
                RotateToMovement(direction);
            }
        }
        rb.AddForce(direction * currentSpeed / 6, ForceMode.VelocityChange);
    }
    private void RotateToMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 target = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            Quaternion targetRotation = Quaternion.LookRotation(target - transform.position);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotation_speed * Time.deltaTime);
        }
    }
    private void RotateToMovement(Vector3 direction)
    {
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotation_speed * Time.deltaTime);
    }
    private void initializateStart()
    {
        rb = transform.GetComponent<Rigidbody>();
        animatorController = transform.GetComponent<AnimatorController>();
    }
    void UpdateDirection(Vector3 direction)
    {
        float angle = Vector3.SignedAngle(direction, transform.forward, Vector3.up);

        if (angle >= 157.5f || angle < -157.5f)
        {
            animatorController.WalkBack();
            //atras
        }
        else if (angle >= -157.5f && angle < -112.5f)
        {
            animatorController.WalkBackRight();
            //atras derecha
        }
        else if (angle >= -112.5f && angle < -67.5f)
        {
            animatorController.WalkRight();
            //derecha
        }
        else if (angle >= -67.5f && angle < -22.5f)
        {
            animatorController.WalkFrontRight();
            //adelante derecha
        }
        else if (angle >= -22.5f && angle < 22.5f)
        {
            animatorController.WalkSlow();
            //adelante
        }
        else if (angle >= 22.5f && angle < 67.5f)
        {
            animatorController.WalkFrontLeft();
            //"adelante izquierda
        }
        else if (angle >= 67.5f && angle < 112.5f)
        {
            animatorController.WalkLeft();
            //izquierda
        }
        else if (angle >= 112.5f && angle < 157.5f)
        {
            animatorController.WalkBackLeft();
            //atras izquierda
        }
    }
}
