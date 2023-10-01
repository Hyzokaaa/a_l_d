using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetControl : MonoBehaviour
{
    public Vector3 groundNormal;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position + new Vector3(0, 1.5f, 0), Vector3.down);
        if (Physics.Raycast(ray, out RaycastHit info, 10))
        {
            transform.position = info.point;
            groundNormal = info.normal;
        }
    }
}
