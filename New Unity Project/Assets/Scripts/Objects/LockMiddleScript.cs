using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LockMiddleScript : MonoBehaviour, ObjectScript, LockScript
{
    Animator anim;
    private LockUIManager lockUIManager;

    [SerializeField]
    public DrawerScript drawer;

    private enum mState
    {
        LOCK,
        UNLOCK
    }
    private mState state = mState.LOCK;

    void Start()
    {
        anim = GetComponent<Animator>();
        lockUIManager = FindObjectOfType<LockUIManager>();
    }

    public void Touch()
    {
        if (state == mState.LOCK) lockUIManager.Open(1, this as LockScript);
    }

    public bool Use(int itemId)
    {
        return false;
    }

    public void Unlock()
    {
        state = mState.UNLOCK;
        anim.SetBool("isOpen",true);
        anim.SetTrigger("open");
        drawer.Unlock();
    }
}