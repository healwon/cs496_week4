using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ConstructionController : MonoBehaviour {

    [SerializeField]
    private Camera playerCamera;
    private GameObject itemObject;
    private float distance = 0.1f;

    // Update is called once per frame
    void Update () {

        if ( itemObject != null ) {
            itemObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward * distance;
            itemObject.transform.rotation = new Quaternion(playerCamera.transform.rotation.x,
                                                playerCamera.transform.rotation.y,
                                                playerCamera.transform.rotation.z,
                                                playerCamera.transform.rotation.w);
        }
    }

    public void SetItemObject(GameObject go)
    {
        itemObject = Instantiate( go ) as GameObject;
    }

    public void UnsetItemObject()
    {
        itemObject = null;
    }


}