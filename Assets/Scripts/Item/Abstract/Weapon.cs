using System;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    [SerializeField]
    private int damage;
    [SerializeField]
    private int range;

    public int Damage { get => damage; set => damage = value; }
    public int Range { get => range; set => range = value; }
}
