using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactorySimpleMaterial : ItemFactory
{
    [SerializeField]
    private SimpleMaterialType type = SimpleMaterialType.Gelatin;


    public override Item Create()
    {
        switch (this.type)
        {
            case SimpleMaterialType.Gelatin:
                return new Gelatin();
            case SimpleMaterialType.Quartz:
                return new Quartz();
            case SimpleMaterialType.Pyrite:
                return new Pyrite();
            case SimpleMaterialType.Uremia:
                return new Uremia();
            case SimpleMaterialType.Biocellulose:
                return new Biocellulose();
            case SimpleMaterialType.SpaceGeode:
                return new SpaceGeode();
            case SimpleMaterialType.Skin:
                return new Skin();
            default:
                return null;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Item a = Create();
            print(a.ItemName + " " + a.Description);
        }
    }
}
