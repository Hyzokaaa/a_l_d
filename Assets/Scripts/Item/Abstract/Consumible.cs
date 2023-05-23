using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Consumible : Item, IConsumible
{
    [SerializeField]
    private int value;

    public abstract void Consume();
}
