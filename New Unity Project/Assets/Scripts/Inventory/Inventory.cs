using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    public Sprite defaultImg;
    public GameObject slotPrefab;
    public List<Item> items;

    public List<GameObject> slots = new List<GameObject>();

    public void AddSlot(int itemId)
    {
        GameObject newSlot = Instantiate(slotPrefab, Vector3.zero, Quaternion.identity, gameObject.transform) as GameObject;
        Slot slot = newSlot.GetComponent<Slot>();
        Item item = items[itemId];
        slot.SetItem(item.itemImage, item.itemName, item.itemId);
        slots.Add(newSlot);
    }

    public void RemoveSlot(GameObject go)
    {
        slots.Remove(go);
        Destroy(go);
    }
}