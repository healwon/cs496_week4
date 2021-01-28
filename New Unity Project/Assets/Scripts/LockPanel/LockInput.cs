using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockInput : MonoBehaviour
{
    private InputField txt;

    void Start()
    {
        txt = gameObject.GetComponent<InputField>();
    }

    public void Clear()
    {
        txt.text = "";
    }

    public void Remove()
    {
        if (txt.text.Length == 1) Clear();
        else if (txt.text.Length > 1) txt.text = txt.text.Substring(0, txt.text.Length - 1);
    }

    public void Input(int i)
    {
        if (txt.text.Length < 5) txt.text += i;
    }
}