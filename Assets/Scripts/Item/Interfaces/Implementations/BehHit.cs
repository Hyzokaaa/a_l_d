using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehHit : IBehaviour
{
    public void Execute()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Golpeo");
        }
        throw new System.NotImplementedException();
    }
}
