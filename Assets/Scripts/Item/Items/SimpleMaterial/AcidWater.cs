using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AcidWater : Item
{
	    public AcidWater()
    {
        ItemName = "Agua Ácida";
        Description = "se obtiene de estanques ácidos o lluvias ácidas. Se requiere un envase para almacenarla.";
        IsMaterial = true;
        Behaviour = null;
        Recipe = null;
    }
}