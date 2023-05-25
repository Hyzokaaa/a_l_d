using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryWeaponRange : ItemFactory
{
    public Weapon weaponPrefab;
    public override Item Create(string name, string description, bool isMaterial, IBehaviour behaviour, int damage)
    {
        Weapon weapon = Instantiate(weaponPrefab);
        weapon.ItemName = name;
        weapon.Description = description;  
        weapon.IsMaterial = isMaterial;
        weapon.Behaviour = behaviour;
        return weapon;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            this.Create(ItemName, Description, IsMaterial, Behaviour);
        }
    }
}
