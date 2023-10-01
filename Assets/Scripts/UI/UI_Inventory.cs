using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    private TextMeshProUGUI inventoryTM;
    private Inventory inventory;
    private GameObject selectedItem;

    void Awake()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        inventoryTM = GetComponentInChildren<TextMeshProUGUI>();
        selectedItem = null;
        
        inventoryTM.enableWordWrapping = false;
        inventory.Changes += UpdateUI;
        //inventory.Changes += SpawnSelectedItem;
        UpdateUI();
    }

    void UpdateUI()
    {
        if(inventory.GetSelectedItem() != null)
        {
            inventoryTM.text = "Comportamiento: " + inventory.GetBehaviour() +
            "\nObjeto Seleccionado: " + inventory.GetSelectedIndex() +
            "\n" + inventory.GetSelectedItem().ItemName;
        }
        else
        {
            inventoryTM.text ="Objeto Seleccionado: " + inventory.GetSelectedIndex() +
             "\nNo Hay Item";
        }
    }
    void SpawnSelectedItem()
    {
        if (inventory.GetSelectedItem() != null)
        {
            Destroy(selectedItem);
            selectedItem = Instantiate(inventory.GetSelectedItem().Prefab, GameObject.FindGameObjectWithTag("Hand").transform);
            selectedItem.transform.localPosition = Vector3.zero;
        }
        else
        {
            Destroy(selectedItem);
        }
    }
}
