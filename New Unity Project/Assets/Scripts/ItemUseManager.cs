using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUseManager : MonoBehaviour
{
    public bool Use(int itemId, Vector2 pos)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit hit;
        Physics.Raycast (ray, out hit);

        if (hit.collider != null) {
            GameObject go = hit.collider.gameObject;
            string name = go.name;
            Debug.Log("MyDebug5: " + name);
            
            ObjectScript os = go.GetComponent<ObjectScript>();
            if (os != null) return os.Use(itemId);
            return false;
        }
        return false;
    }
}
