using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemObject : MonoBehaviour, ObjectScript
{
    public int itemId;
    private Inventory inventory;

    void Start() {
        inventory = FindObjectOfType<Inventory>();
    }

    public void Touch()
    {
        inventory.AddSlot(itemId);
        gameObject.SetActive(false);
    }

    public bool Use(int itemId)
    {
        return false;
    }
}