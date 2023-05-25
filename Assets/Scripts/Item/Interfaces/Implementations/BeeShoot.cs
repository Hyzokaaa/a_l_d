using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeShoot : IBehaviour
{
    public void Execute()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Disparo");
        }
        throw new System.NotImplementedException();
    }
}
