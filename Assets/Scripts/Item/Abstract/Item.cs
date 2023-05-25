using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private string itemName;
    [SerializeField]
    private string description;
    [SerializeField]
    private bool isMaterial;
    [SerializeField]
    private IBehaviour behaviour;

    public string ItemName { get => itemName; set => itemName = value; }
    public string Description { get => description; set => description = value; }
    public bool IsMaterial { get => isMaterial; set => isMaterial = value; }
    public IBehaviour Behaviour { get => behaviour; set => behaviour = value; }
}
