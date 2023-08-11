using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject cellButton;
    private Inventory inventory;
    public int id;

    private void Start()
    {
        inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.cells.Length; i++)
            {
                if (!inventory.isFull[i])
                {
                    inventory.isFull[i] = true;
                    Instantiate(cellButton, inventory.cells[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }

}
