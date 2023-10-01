Jerarquia

    f.Scripts
        f.Camera
            MovCamera
        f.Craft
            CraftingManager
        f.Enemy
            f.Spider
                IKControl
                SpiderMovement
                TargetControl
        f.Item
            f.Abstract
                Consumible
                Item
                Tool
                Weapon
            f.Factory
                ItemFactory
            f.Interfaces
                f.Implementations
                    BehBreakMineral
                    BehShoot
                    BehAddStats
                    BehHit
                    BehScan
                IBehaviour
            f.Items
                f.SimpleMaterial
                    Biocellulose
                    Gelatin
                    Pyrite
                    Quartz
                    Skin
                    SpaceGeode
                    Uremia
                f.Tool
                    Scanner
            f.Util
                ItemPrefab
                ItemType
        f.Player
            f.Inventory
                Inventory
            AnimatorController
            ItemPickUp
            PlayerController
            PlayerMovement
            PlayerStatus
        f.UI
            UI_Inventory
        GameController


Personaje del jugador: El personaje del jugador tiene varios scripts asociados para manejar diferentes aspectos de su comportamiento. PlayerStatus se utiliza para manejar las estadísticas del personaje, PlayerMovement controla el movimiento y la rotación del personaje, CharacterAnimation se utiliza para configurar y controlar las animaciones, e Inventory maneja el inventario del personaje.

Objetos: Los objetos en tu juego tienen una jerarquía de clases. Item es la clase base, de la que heredan Weapon, Consumable y Tool. Cada objeto tiene un nombre, una descripción, un booleano para determinar si es un material, un comportamiento (IBehaviour) y una lista de objetos para la receta de fabricación.

Comportamientos de los objetos: Los comportamientos de los objetos se implementan a través de la interfaz IBehaviour, que tiene un método void Execute(). Cada objeto puede tener su propio comportamiento definido.

Inventario: La clase Inventory tiene un método UseItem() en su actualización para ejecutar el comportamiento del objeto activo.

Fábricas de objetos: Tienes fábricas para crear instancias de diferentes tipos de items. Por ejemplo, tienes clases cuya única función es tener los datos que requiere el objeto para ser instanciado por la fábrica.

Recolección de objetos: Tienes una lógica para recoger objetos en el mundo del juego. Cuando el jugador presiona una tecla específica y hay objetos recolectables cerca, estos objetos se añaden al inventario del jugador.

Crafteo de objetos: Estás trabajando en la lógica para craftear nuevos objetos a partir de los items en el inventario del jugador. Has creado un método Craft que verifica si el jugador tiene los materiales necesarios para craftear un item.

Enemigos: Los enemigos en tu juego, como las arañas, tienen sus propios scripts para controlar su movimiento y comportamiento.


-----

# Descripciones:
## 1- PlayerStatus: 
De momento estan pensadas las siguientes variables:
* private int health;
* private int oxigen;
* private int water;

(Aun no se ha implementado la logica de estas funciones)

-----

## 2- PlayerMovement: 
- gestiona la velocidad de movimiento del jugador en funcion del input, en sus distintas formas
    - caminar
    - correr
    - caminar apuntando al raton (menos veloz solo caminando)
- se gestiona la velocidad de rotacion (lerp entre la rotacion actual y la rotacion objetivo)
- inicializa las fisicas

-----
## 3- AnimatorController: 
Maneja las variables que utiliza el animator internamente, tiene un metodo RunMotion() que se encarga de establecer las variables para los distintos estados de la maquina de estados de animator.

    private void RunMotion()
    {
        anim.SetFloat("speedX", speedX);
        anim.SetFloat("speedY", speedY);
    }

-----
## 4- Item:
Existe una clase padre Item la cual posee los siguientes campos:
- string itemName -> nombre del objeto
- string descripcion ->  descripcion del objeto
- bool isMaterial -> determina si es material o no
- IBehaviour behaviour -> comportamiento del objeto
- List<Item<Item>> recipe -> lista de objetos para construirlo
- GameObject prefab -> GameObject de la geometria

De esta clase Heredan otros tipos de Items como Consumible, Tool y Weapon; y en funcion de su tipo heredan las instancias reales, por ejemplo de Item tenemos materiales como Biocellulose, Gelatin, etc... cada uno de estos se define de la siguiente forma:

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

Asimismo con el resto de objetos:
- Gelatin
- Pyrite
- Quartz
- Skin
- SpaceGeode
- Uremia
- Scan ...

Esta pendiente actualmente:
- Definir si eliminar el tipo Weapon ya que su utilidad era agregar un Behaviour para atacar y creo mejor permitir atacar con cualquier item asi sea un material basico.
- Definir caracteristicas de los consumibles
- Definir resto de items

-----
## 5- Behaviour(Comportamiento):
Cada Item tiene uno o mas comportamientos, la clase **Item** tiene un atributo comportamiento mientras que algunas de sus clases hijo como Tool tienen un campo **IBehaviour secondBehaviour** 

IBehaviour es una interface definida como:

    public interface IBehaviour 
    {
        void Execute();
    }

Y tiene implementaciones pendientes a desarrollar como:

    public class BehHit : IBehaviour
    {
        public void Execute()
        {
            Debug.Log("Golpeo");
        }
    }
O BehScan, BehShoot, BehAddStats  y otros.

-----
## 6- Inventory:
La clase inventario se encarga de la gestion de los objetos que trae el jugador, la misma tiene los siguientes campos:
- Dictionary<<int, Item>> items
- int slots
- int selectedItem
- int selectedBehaviour
- event Action Changes

Y los siguientes metodos:
- void AddItem(Item item)
- void RemoveItem(int index)
- public void UseItem()
- void RotateInventory()
- void ChangeBehaviour()
- int GetBehaviour()
- int GetSelectedIndex()
- Item GetSelectedItem()

Esta seria la implementacion de UseItem() (pendiente a terminar de implementar)

    public void UseItem()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (items.Count <= 0)
            {
                //print("no tengo item");
                return;
            }
            if (!items.ContainsKey(selectedItem))
            {
                //print("no tengo el item " + selectedItem + " asignado");
                return;
            }
            if (items[selectedItem] is Tool)
            {
                if (selectedBehaviour == 0)
                {
                    items[selectedItem].Behaviour.Execute();
                }
                else if (selectedBehaviour == 1)
                {
                    Tool item = items[selectedItem] as Tool;
                    item.SecondBehaviour.Execute();
                }
            }
            else if (items[selectedItem] is Weapon)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    items[selectedItem].Behaviour.Execute();
                }
            }
        }
    }


-----
## 7- Factory:
Existe una clase ItemFactory que se encarga de crear un objeto en funcion de su ItemType

    public Item Create(ItemType type)
    {
        switch (type)
        {
            case ItemType.Gelatin:
                return new Gelatin();
            case ItemType.Quartz:
                return new Quartz();
            case ItemType.Pyrite:
                return new Pyrite();
            case ItemType.Uremia:
                return new Uremia();
            case ItemType.Biocellulose:
                return new Biocellulose();
            case ItemType.SpaceGeode:
                return new SpaceGeode();
            case ItemType.Skin:
                return new Skin();
            case ItemType.Scanner:
                return new Scanner();
            case ItemType.Axe:
                return null;
            case ItemType.Knife:
                return null;
            case ItemType.Drill:
                return null;
            case ItemType.BowSimple:
                return null;
            case ItemType.BowSpecial:
                return null;
            case ItemType.SwordSimple:
                return null;
            case ItemType.SwordSpecial:
                return null;
            case ItemType.CrossbowSimple:
                return null;
            case ItemType.CrossbowSpecial:
                return null;
            case ItemType.RifleSimple:
                return null;
            case ItemType.RifleSpecial:
                return null;
            default:
                return null;
        }
    }

Estando pendientes algunos de los casos del switch por implementar.
