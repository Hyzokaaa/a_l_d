using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pyrite : Item
{
    public Pyrite()
    {
        ItemName = "Pirita";
        Description = "Un mineral rojizo e inflamable utilizado para hacer chispas, armas" +
            " y explosivos.";
        IsMaterial = true;
        Behaviour = null;
        Recipe = null;
    }
}

