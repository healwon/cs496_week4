using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ChestScript : MonoBehaviour, ObjectScript, LockScript
{
    Animator anim;
    public GameObject content;
    private LockUIManager lockUIManager;

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
        if (state == mState.LOCK) lockUIManager.Open(3, this as LockScript);
    }

    public bool Use(int itemId)
    {
        return false;
    }

    public void Unlock()
    {
        state = mState.UNLOCK;
        content.SetActive(true);
        anim.SetTrigger("isOpen");
    }
}