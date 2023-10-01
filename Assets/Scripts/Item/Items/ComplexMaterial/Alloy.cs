using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alloy : Item
{
    public Alloy()
    {
        ItemName = "Aleación";
        Description = "Se calienta el uremio hasta su punto de fusión y luego se enfría lentamente para formar una aleación. La aleación es un material compuesto resistente y duradero, conocido por su resistencia al desgaste y a la corrosión. Su versatilidad permite su uso en una amplia gama de aplicaciones, lo que lo convierte en un recurso valioso para cualquier misión de supervivencia. ¡Un verdadero testimonio del ingenio humano frente a la adversidad!";
        IsMaterial = true;
        Recipe = new List<Item> {new Uremia()};
        // Agrega aquí las demás propiedades
    }
}
