using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    private bool isStay = false;
    Inventory inventory = null;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isStay == true)
        {
            Item spawn = gameObject.GetComponent<ItemFactory>().Create();
            print(spawn.ItemName);
            inventory.AddItem(spawn);
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isStay = true;
            inventory = other.GetComponent<Inventory>();
            print("estas en la piedra crack");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isStay = false;
        inventory = null;
        print("saliste de la piedra crack");
    }
}
