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
        Collect();
    }

    private void Collect()
    {
        if(Input.GetKeyDown(KeyCode.E) && targets.Count > 0)
        {
            target = targets[0];
            ItemType itemType = target.GetComponent<CollectableType>().itemType;
            Item collect = targets[0].GetComponent<ItemFactory>().Create(itemType);
            inventory.AddItem(collect);
            targets.RemoveAt(0);
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
