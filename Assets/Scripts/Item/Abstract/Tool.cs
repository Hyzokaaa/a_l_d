using System;
using System.Collections.Generic;
using UnityEngine;
public abstract class Tool : Item
{
    [SerializeField]
    private int damage;
    [SerializeField]
    private int range;
    [SerializeField]
    private IBehaviour secondBehaviour;
}
