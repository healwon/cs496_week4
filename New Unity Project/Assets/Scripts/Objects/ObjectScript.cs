using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public interface ObjectScript
{
    public void Touch(); 

    public bool Use(int itemId);
}