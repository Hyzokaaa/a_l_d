using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryWeapon : ItemFactory
{
    [SerializeField]
    private WeaponType type = WeaponType.BowSimple;
    [SerializeField]
    private int maxDamage;
    [SerializeField]
    private int minDamage;
    [SerializeField]
    private int maxRange;
    [SerializeField]
    private int minRange;
    public override Item Create()
    {
        switch (this.type) {
            case WeaponType.BowSimple:
                return null;
            case WeaponType.BowSpecial:
                return null;
            case WeaponType.SwordSimple:
                return null;
            case WeaponType.SwordSpecial:
                return null;
            case WeaponType.CrossbowSimple:
                return null;
            case WeaponType.CrossbowSpecial:
                return null;
            case WeaponType.RifleSimple:
                return null;
            case WeaponType.RifleSpecial:
                return null;
            default:
                return null;
        }
    }
    



}
