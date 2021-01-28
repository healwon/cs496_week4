using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragSlot : MonoBehaviour
{
    static public DragSlot instance;
    private Image imageItem;

    void Start()
    {
        instance = this;
        imageItem = gameObject.GetComponent<Image>();
        UnsetDragImage();
    }

    public void SetDragImage(Sprite img)
    {
        imageItem.sprite = img;
        SetColor(1);
    }

    public void UnsetDragImage()
    {
        imageItem.sprite = null;
        SetColor(0);
    }

    public void SetColor(float _alpha)
    {
        Color color = imageItem.color;
        color.a = _alpha;
        imageItem.color = color;
    }
}