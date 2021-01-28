using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryScript : MonoBehaviour, ObjectScript
{
    Animator anim;
    public GameObject go;

    private enum mState
    {
        DEFAULT,
        SMALL,
        SMALLER,
        SMALLEST,
    }
    private mState state = mState.DEFAULT;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Touch()
    {
        switch(state)
        {
            case mState.DEFAULT:
                anim.SetTrigger("small");
                anim.SetBool("state_small", true);
                state = mState.SMALL;
                break;
            case mState.SMALL:
                anim.SetTrigger("smaller");
                anim.SetBool("state_smaller", true);
                state = mState.SMALLER;
                break;
            case mState.SMALLER:
                anim.SetTrigger("smallest");
                state = mState.SMALLEST;
                break;
            case mState.SMALLEST:
                go.SetActive(false);
                break;
            default:
                break;
        }
    }
    
    public bool Use(int itemId)
    {
        return false;
    }
}