using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEnd : MonoBehaviour
{
    public void BackToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
