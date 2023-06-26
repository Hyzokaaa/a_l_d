using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tool : Weapon
{
    [SerializeField]
    private IBehaviour secondBehaviour;

    public IBehaviour SecondBehaviour { get => secondBehaviour; set => secondBehaviour = value; }
}
