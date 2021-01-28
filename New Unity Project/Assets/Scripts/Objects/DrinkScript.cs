using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkScript : MonoBehaviour, ObjectScript
{
    private DrinkController drinkController;

    void Start()
    {
        drinkController = FindObjectOfType<DrinkController>();
    }

    public void Touch()
    {
        drinkController.Drink();
        gameObject.SetActive(false);
    }

    public bool Use(int itemId)
    {
        return false;
    }
}
