using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMain : MonoBehaviour
{
    [SerializeField]
    public FadeControllerImage fadeController;

    public void GameStart()
    {
        fadeController.FadeIn(0.7f, () =>
        {
            SceneManager.LoadSceneAsync("CutScene");
        });
        //SceneManager.LoadSceneAsync("CutScene");
    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
