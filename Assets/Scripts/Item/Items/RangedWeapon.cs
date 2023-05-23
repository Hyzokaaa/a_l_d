using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : Item, IRangedWeapon
{
    public int Damage { get; set; }

    public void Atack()
    {
        throw new System.NotImplementedException();
    }
}

