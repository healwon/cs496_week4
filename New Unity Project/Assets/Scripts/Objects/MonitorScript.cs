using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MonitorScript : MonoBehaviour
{
    [SerializeField]
    public Material materialOn;
    public Material materialConnect;

    public void TurnOn()
    {
        Material[] materials = gameObject.GetComponent<MeshRenderer>().materials;
        materials[1] = materialOn;
        gameObject.GetComponent<MeshRenderer>().materials = materials;
    }

    public void Connect()
    {
        Material[] materials = gameObject.GetComponent<MeshRenderer>().materials;
        materials[1] = materialConnect;
        gameObject.GetComponent<MeshRenderer>().materials = materials;
    }
}