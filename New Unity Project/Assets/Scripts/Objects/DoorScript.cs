using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour, ObjectScript
{
    Animator anim;
    private ButtonPlay btnManager;

    private enum mState
    {
        INIT,
        OPEN
    }
    private mState state = mState.INIT;

    void Start()
    {
        anim = GetComponent<Animator>();
        btnManager = FindObjectOfType<ButtonPlay>();
    }

    public void Touch()
    {
        anim.SetTrigger("shake");
    }

    public bool Use(int itemId)
    {
        switch (state)
        {
            case mState.INIT:
                if (itemId == 0) {
                    Open();
                    state = mState.OPEN;
                    return true;
                }
                break;
            default:
                break;
        }
        return false;
    }

    public void Open()
    {
        anim.SetTrigger("isOpen");
        btnManager.LoadEndingScene();
    }
}
