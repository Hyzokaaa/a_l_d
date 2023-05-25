using System;
using System.Collections.Generic;
using UnityEngine;
public abstract class ItemFactory : Item
{
    public abstract Item Create(string name, string description, bool isMaterial, IBehaviour behaviour);
}
