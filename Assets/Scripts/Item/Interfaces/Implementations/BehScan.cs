using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehScan : IBehaviour
{
    public void Execute()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Escaneo");
        }
    }
}
