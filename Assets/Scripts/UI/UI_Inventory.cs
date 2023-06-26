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
        selectedItem = null;
        inventoryTM = GetComponentInChildren<TextMeshProUGUI>();
        inventoryTM.enableWordWrapping = false;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        inventory.Changes += UpdateUI;
        inventory.Changes += SpawnSelectedItem;
        UpdateUI();
    }

    void UpdateUI()
    {
        inventoryTM.text = "Comportamiento: " + inventory.getBehaviour() +
        "\nObjeto Seleccionado: " + inventory.getSelectedIndex();
    }
    void SpawnSelectedItem()
    {
        if (inventory.getSelectedItem() != null)
        {
            Destroy(selectedItem);
            selectedItem = Instantiate(inventory.getSelectedItem().Prefab, GameObject.FindGameObjectWithTag("Hand").transform);
            selectedItem.transform.localPosition = Vector3.zero;
        }
        else
        {
            Destroy(selectedItem);
        }
    }
}
