using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExCube : MonoBehaviour, ObjectScript
{
    int maxColorCount;
    int currentColor;
    Material material;
    public Color[] colors;

    private Inventory inventory;

    void Start() {
        maxColorCount = colors.Length;
        currentColor = 0;
        material = GetComponent<MeshRenderer>().material;
        material.color = colors[currentColor];

        inventory = FindObjectOfType<Inventory>();
    }

    void Update()
    {
        material.color = colors[currentColor];
    }

    public void Touch()
    {
        currentColor++;
        if (currentColor >= maxColorCount)
        {
            inventory.AddSlot(0);
            currentColor = 0;
        }
    }

    public bool Use(int itemId)
    {
        return false;
    }
}
