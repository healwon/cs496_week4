using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Sprite itemImage;
    public string itemName;
    public int itemId;
    private Inventory inventory;
    private ItemUseManager itemUseManager;

    public void SetItem(Sprite _itemImage, string _itemName, int _itemId)
    {
        itemImage = _itemImage;
        itemName = _itemName;
        itemId = _itemId;

        GameObject imagego = gameObject.transform.Find("Image").gameObject;
        Image img = imagego.GetComponent<Image>();
        img.sprite = itemImage;

        GameObject textgo = gameObject.transform.Find("Text").gameObject;
        Text txt = textgo.GetComponent<Text>();
        txt.text = itemName;
    }

    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        itemUseManager = FindObjectOfType<ItemUseManager>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("MyDebug4: "+inventory);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("MyDebug4:1 "+inventory);
        DragSlot.instance.SetDragImage(itemImage);
        DragSlot.instance.transform.position = eventData.position;
        
        Image img = gameObject.transform.Find("Image").gameObject.GetComponent<Image>();
        Color color = img.color;
        color.a = 0.5f;
        img.color = color;
    }

    public void OnDrag(PointerEventData eventData)
    {
        DragSlot.instance.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("MyDebug4:2 "+inventory);
        DragSlot.instance.UnsetDragImage();

        Image img = gameObject.transform.Find("Image").gameObject.GetComponent<Image>();
        Color color = img.color;
        color.a = 1f;
        img.color = color;

        if (itemUseManager.Use(itemId, eventData.position))
        {
            inventory.RemoveSlot(gameObject);
        }
    }
}