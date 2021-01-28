using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockUIManager : MonoBehaviour
{
    [SerializeField]
    private LockPanelScript[] panels;

    public void Open(int index, LockScript mLock)
    {
        if (index < panels.Length)
        {
            panels[index].Open(mLock);
        }
    }
}
