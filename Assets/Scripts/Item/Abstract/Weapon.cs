using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : Item
{
    [SerializeField]
    private int damage;
    [SerializeField]
    private int range;

    public int Damage { get => damage; set => damage = value; }
    public int Range { get => range; set => range = value; }
}
