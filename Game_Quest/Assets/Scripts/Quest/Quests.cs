using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quests : MonoBehaviour
{
    public int quantityOfQuest = 0;
    public int questNumber;
    public int[] items;
    public GameObject[] key;
    private bool isNotEnd = true;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (items.Length > 0 && isNotEnd)
        {
            if (other.tag != "Player" && other.gameObject.GetComponent<PickUp>().id == items[quantityOfQuest])
            {
                questNumber++;
                Destroy(other.gameObject);
                CheckQuest();
                quantityOfQuest++;

                if (quantityOfQuest == items.Length)
                {
                    isNotEnd = false;
                }
            }
        }
    }

    public void CheckQuest()
    {
        if (questNumber == 1)
        {
            key[quantityOfQuest].SetActive(true);
            questNumber = 0;
        }
    }
}
