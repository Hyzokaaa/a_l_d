using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponMaterial : Item, IMeleeWeapon, IMaterial
{
    public int Damage { get; set; }

    public void Atack()
    {
        throw new System.NotImplementedException();
    }
}
