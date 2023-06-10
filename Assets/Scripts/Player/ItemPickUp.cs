using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    Inventory inventory;
    List<GameObject> targets;
    GameObject target;

    private void Awake()
    {
        targets = new List<GameObject>();
        inventory = GetComponent<Inventory>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && targets.Count > 0)
        {
            target = targets[0];
            Item spawn = target.GetComponent<ItemFactory>().Create();
            print(spawn.ItemName);
            inventory.AddItem(spawn);
            targets.Remove(target);
            Destroy(target);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            targets.Add(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            targets.Remove(other.gameObject);
        }
    }
}
