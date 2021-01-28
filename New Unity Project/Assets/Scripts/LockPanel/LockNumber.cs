using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockNumber : MonoBehaviour
{
    private Text txt;

    void Start()
    {
        txt = gameObject.GetComponent<Text>();
    }

    public void Increase()
    {
        int t = int.Parse(txt.text);
        t = (t+1)%10;
        txt.text = t.ToString();
    }
}