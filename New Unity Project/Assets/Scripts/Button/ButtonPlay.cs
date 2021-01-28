using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    [SerializeField]
    public GameObject pauseUI;
    public FadeControllerImage fadeController;

    public void Resume() {
        pauseUI.SetActive(false);
    }
    public void Help() {
    
    }
    public void Quit() {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadEndingScene()
    {
        fadeController.FadeIn(3f, () =>
        {
            SceneManager.LoadScene("EndingScene");
        });
    }

    void Start() {
        pauseUI.SetActive(false);
    }
    
    void Update() {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseUI.SetActive(!pauseUI.activeSelf);
        }
    }
}
