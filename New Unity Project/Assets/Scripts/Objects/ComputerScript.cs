using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ComputerScript : MonoBehaviour, ObjectScript
{
    Animator anim;
    private bool bMouse;
    private bool bKeyboard;
    private bool bMonitor;
    private bool bPhone;
    private bool bCable;

    private enum mState
    {
        OFF,
        ON,
        CONNECTED
        
    }
    private mState state = mState.OFF;

    [SerializeField]
    public GameObject Mouse_obj;
    public GameObject Keyboard;
    public GameObject Monitor_obj;
    public GameObject CellPhone;
    public GameObject cable_piece;
    public GameObject mnt1;
    public GameObject mnt2;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Touch()
    {
        switch(state)
        {
            case mState.OFF:
                if ((bMouse && bKeyboard) && bMonitor)
                {
                    mnt1.GetComponent<MonitorScript>().TurnOn();
                    mnt2.GetComponent<MonitorScript>().TurnOn();
                    Keyboard.GetComponent<KeyboardScript>().TurnOn();
                    state = mState.ON;
                }
                break;
            case mState.ON:
                if (bPhone && bCable)
                {
                    mnt1.GetComponent<MonitorScript>().Connect();
                    mnt2.GetComponent<MonitorScript>().Connect();
                    CellPhone.GetComponent<PhoneScript>().Connect();
                    state = mState.CONNECTED;
                }
                break;
            default:
                break;
        }
        return;
    }

    public bool Use(int itemId)
    {
        if(itemId == 1){
            Mouse_obj.SetActive(true);
            bMouse = true;
            return true;
        }
        else if(itemId == 2){
            Keyboard.SetActive(true);
            bKeyboard = true;
            return true;
        }
        else if(itemId == 3){
            Monitor_obj.SetActive(true);
            bMonitor = true;
            return true;
        }
        else if(itemId == 4){
            CellPhone.SetActive(true);
            bPhone = true;
            return true;
        }
        else if(itemId == 5){
            cable_piece.SetActive(true);
            bCable = true;
            return true;
        }
        return false;
    }
}
