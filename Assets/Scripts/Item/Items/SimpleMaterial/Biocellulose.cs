using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Biocellulose : Item
{
    public Biocellulose()
    {
        ItemName = "Biocelulosa";
        Description = "Un objeto utilizado para hacer muebles, palos y papel, obtenido al cortar" +
            " Árboles o ramas de Xilofón.";
        IsMaterial = true;
        Behaviour = null;
        Recipe = null;
    }

}

