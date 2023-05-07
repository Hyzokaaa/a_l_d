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
    [SerializeField]
    Animator animator;

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
        Vector3 direction = new Vector3(axisHorizontal , 0f, axisVertical).normalized;
        float currentSpeed = walk_speed;

        if (direction == Vector3.zero)
        {
            animator.SetInteger("Walk", 0);
        }

        else if ((Vector3.Angle(direction, transform.forward) <= 70.0f) == false)
        {
            animator.SetInteger("Walk", -1);
            currentSpeed = back_speed;
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetInteger("Walk", 2);
                currentSpeed = run_speed;
            }
            else
            {
                animator.SetInteger("Walk", 1);
            }
        }
        rb.MovePosition(transform.position + direction * currentSpeed * Time.deltaTime);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 target = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            Quaternion targetRotation = Quaternion.LookRotation(target - transform.position);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotation_speed * Time.deltaTime);
        }
    }
    private void initializateStart()
    {
        rb = transform.GetComponent<Rigidbody>();
        animator = transform.GetComponent<Animator>(); 
    }
}
