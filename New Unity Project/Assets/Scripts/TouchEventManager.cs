using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TouchEventManager : MonoBehaviour
{
    void Update () 
    {
        // 터치 입력이 들어올 경우
        if (Input.GetMouseButtonDown(0))
        {
            if (Input.touchCount > 0) {

                if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    return;
                }
                
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;
                Physics.Raycast (ray, out hit);

                if (hit.collider != null) { 
                    GameObject go = hit.collider.gameObject;
                    string name = go.name;
                    Debug.Log("MyDebug2: " + name);

                    ObjectScript os = go.GetComponent<ObjectScript>();
                    if (os != null) os.Touch();
                }
            }
        }
    }
}


