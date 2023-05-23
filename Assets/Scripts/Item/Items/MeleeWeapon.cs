using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : Item, IMeleeWeapon
{
    public int Damage { get ; set; }

    public void Atack()
    {
        throw new System.NotImplementedException();
    }
}
