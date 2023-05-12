using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float walk_speed;
    [SerializeField]
    private float back_speed;
    [SerializeField]
    private float run_speed;
    [SerializeField]
    private float rotation_speed;
    private Rigidbody rb;

    CharacterAnimation characterAnimation;

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
            characterAnimation.PlayAnimation("Idle");
            //animator.SetInteger("Walk", 0);
        }
        else
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                Debug.Log("estas presionando click derecho, ahora deberias moverte mas lento y rotan en direccion a la posicion del mause en pantalla");
                RotateToMouse();
                UpdateDirection(direction);
                currentSpeed = back_speed;
            }
            else if (Input.GetKey(KeyCode.LeftShift) && !(Input.GetKey(KeyCode.Mouse1)))
            {
                //animator.SetInteger("Walk", 2);
                characterAnimation.PlayAnimation("Run");
                currentSpeed = run_speed;
                RotateToMovement(direction);
            }
            else
            {
                characterAnimation.PlayAnimation("Walk");
                //animator.SetInteger("Walk", 1);
                RotateToMovement(direction);
            }
        }
        rb.MovePosition(transform.position + direction * currentSpeed * Time.deltaTime);
    }

    private void ActivateWalkBack(Vector3 direction)
    {
        if ((Vector3.Angle(direction, transform.forward) <= 70.0f) == false)
        {
            //animator.SetInteger("Walk", -1);
        }
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
        characterAnimation = transform.GetComponent<CharacterAnimation>();
    }
    void UpdateDirection(Vector3 direction)
    {
        float angle = Vector3.SignedAngle(direction, transform.forward, Vector3.up);

        if (angle >= 157.5f || angle < -157.5f)
        {
            characterAnimation.PlayAnimation("WalkB");
            //animator.SetInteger("Walk", -1);
            Debug.Log("atras");
        }
        else if (angle >= -157.5f && angle < -112.5f)
        {
            characterAnimation.PlayAnimation("BackRight");
            //animator.SetInteger("Walk", -3);
            Debug.Log("atras derecha");
        }
        else if (angle >= -112.5f && angle < -67.5f)
        {
            characterAnimation.PlayAnimation("Right");
            //animator.SetInteger("Walk", 8);
            Debug.Log("derecha");
        }
        else if (angle >= -67.5f && angle < -22.5f)
        {
            characterAnimation.PlayAnimation("Walk");
            //animator.SetInteger("Walk", 5);
            Debug.Log("adelante derecha");
        }
        else if (angle >= -22.5f && angle < 22.5f)
        {
            characterAnimation.PlayAnimation("Walk");
            //animator.SetInteger("Walk", 7);
            Debug.Log("adelante");
        }
        else if (angle >= 22.5f && angle < 67.5f)
        {
            characterAnimation.PlayAnimation("Walk");
            //animator.SetInteger("Walk", 4);
            Debug.Log("adelante izquierda");
        }
        else if (angle >= 67.5f && angle < 112.5f)
        {
            characterAnimation.PlayAnimation("Left");
            //animator.SetInteger("Walk", 9);
            Debug.Log("izquierda");
        }
        else if (angle >= 112.5f && angle < 157.5f)
        {
            characterAnimation.PlayAnimation("BackLeft");
            //animator.SetInteger("Walk", -2);
            Debug.Log("atras izquierda");
        }
    }
}
