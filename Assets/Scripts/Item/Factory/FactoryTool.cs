using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryTool : ItemFactory
{
    [SerializeField]
    private ToolType type = ToolType.Scanner;


    public override Item Create()
    {
        switch (this.type)
        {
            case ToolType.Scanner:
                return new Scanner();
            case ToolType.Axe:
                return null;
            case ToolType.Knife:
                return null;
            case ToolType.Drill:
                return null;
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
