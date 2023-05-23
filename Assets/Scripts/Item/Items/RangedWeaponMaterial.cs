using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeaponMaterial : Item., IRangedWeapon, IMaterial
{
    public int Damage { get; set; }

    public void Atack()
    {
        throw new System.NotImplementedException();
    }
}
