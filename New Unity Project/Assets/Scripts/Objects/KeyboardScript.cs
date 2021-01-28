using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class KeyboardScript : MonoBehaviour
{
    [SerializeField]
    public Material material;

    public void TurnOn()
    {
        Material[] materials = gameObject.GetComponent<MeshRenderer>().materials;
        materials[0] = material;
        gameObject.GetComponent<MeshRenderer>().materials = materials;
    }
}