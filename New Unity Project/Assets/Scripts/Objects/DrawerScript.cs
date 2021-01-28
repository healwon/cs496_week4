using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DrawerScript : MonoBehaviour, ObjectScript
{
    Animator anim;
    public GameObject content;

    private enum mState
    {
        LOCK_CLOSE,
        UNLOCK_CLOSE,
        UNLOCK_OPEN
    }
    private mState state = mState.LOCK_CLOSE;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Touch()
    {
        switch(state)
        {
            case mState.LOCK_CLOSE:
                anim.SetTrigger("shake");
                break;
            case mState.UNLOCK_CLOSE:
                anim.SetBool("isOpen", true);
                anim.SetTrigger("open");
                state = mState.UNLOCK_OPEN;
                break;
            case mState.UNLOCK_OPEN:
                anim.SetBool("isOpen", false);
                anim.SetTrigger("close");
                state = mState.UNLOCK_CLOSE;
                break;
            default:
                break;
        }
    }

    public bool Use(int itemId)
    {
        return false;
    }

    public void Unlock()
    {
        if (state == mState.LOCK_CLOSE)
        {
            state = mState.UNLOCK_CLOSE;
            content.SetActive(true);
        }
    }
}
