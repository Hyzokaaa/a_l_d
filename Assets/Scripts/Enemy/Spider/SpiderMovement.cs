using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMovement : MonoBehaviour
{
    public float currentSpeed = 10;
    public Rigidbody rb;
    private Vector3 pivot;
    public Transform[] points;


    //
    public float hoverHeight = 1f;
    public float smoothTime = 0.2f;
    public float bobbingAmplitude = 0.1f;
    public float bobbingFrequency = 1f;
    private float verticalVelocity;

    /*void Update()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        if (Physics.Raycast(ray, out RaycastHit hit, 10f))
        {
            float targetHeight = hit.point.y + hoverHeight + Mathf.Sin(Time.time * bobbingFrequency) * bobbingAmplitude;
            float currentHeight = transform.position.y;
            currentHeight = Mathf.SmoothDamp(currentHeight, targetHeight, ref verticalVelocity, smoothTime);
            transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
        }
    }*/

    //
    // Start is called before the first frame update
    void Start()
    {
        pivot = transform.position;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float axisHorizontal = Input.GetAxisRaw("Horizontal");
        float axisVertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(axisHorizontal, 0f, axisVertical).normalized;
        rb.AddForce(direction * currentSpeed / 6, ForceMode.VelocityChange);


        float rotationSpeed = 50f;
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.E))
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
    }

    private void AdaptativePosition()
    {

        Ray ray = new Ray(pivot + new Vector3(0, 0.6f, 0), Vector3.down);
        Debug.DrawRay(pivot + new Vector3(0, 0.6f, 0), Vector3.down);
        if(Physics.Raycast(ray, out RaycastHit info, 10))
        {
            pivot = info.point + new Vector3(0, 0.1f, 0);
        }
        pivot.z = transform.position.z;
        pivot.x = transform.position.x;
    }
    private void Idle()
    {
        transform.position = Vector3.Lerp(transform.position, pivot, 1);
    }

}
