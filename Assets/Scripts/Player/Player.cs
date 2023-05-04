using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float m_speed;
    [SerializeField]
    private float r_speed;
    [SerializeField]
    private float back_speed;
    private Rigidbody rb;

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
        float currentSpeed = m_speed;
        if ((Vector3.Angle(direction, transform.forward) <= 70.0f) == false)
        {
            currentSpeed = back_speed;
        }
        rb.MovePosition(transform.position + direction * currentSpeed * Time.deltaTime);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Vector3 target = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            Quaternion targetRotation = Quaternion.LookRotation(target - transform.position);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, r_speed * Time.deltaTime);
        }
    }
    private void initializateStart()
    {
        rb = transform.GetComponent<Rigidbody>();
    }
}
