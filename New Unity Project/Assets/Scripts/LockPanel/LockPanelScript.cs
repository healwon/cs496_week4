using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LockPanelScript : MonoBehaviour
{
    private LockScript padlock;

    [SerializeField]
    private int[] answer;
    [SerializeField]
    private Text message;
    [SerializeField]
    private Text[] input;

    public void Open(LockScript mLock)
    {
        padlock = mLock;
        gameObject.SetActive(true);
    }

    public void Close()
    {
        message.text="";
        gameObject.SetActive(false);
    }

    public void Unlock()
    {
        if (Match())
        {
            Close();
            padlock.Unlock();
        }
        else {
            message.text="아무 일도 일어나지 않았다...";
        }
    }

    public bool Match()
    {
        if (input[0].text.Length == 0) return false;
        for (int i = 0; i < answer.Length; i++)
        {
            if (answer[i] != int.Parse(input[i].text)) return false;
        }
        return true;
    }
}