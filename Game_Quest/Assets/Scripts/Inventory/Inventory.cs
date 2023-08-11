using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public Cell[] cells;
    public GameObject inventory;
    private bool isInventoryOn;
    private void Start()
    {
        isInventoryOn = false;
    }
    public void Chest()
    {
        if (!isInventoryOn)
        {
            isInventoryOn = true;
            inventory.SetActive(true);
        }
        else if (isInventoryOn)
        {
            isInventoryOn = false;
            inventory.SetActive(false);
        }
    }
}
