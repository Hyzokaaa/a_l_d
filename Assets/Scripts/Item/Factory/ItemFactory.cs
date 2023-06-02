using System;
using System.Collections.Generic;
using UnityEngine;
public abstract class ItemFactory : MonoBehaviour
{
    public abstract Item Create();
}