using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonCutScene : MonoBehaviour
{
    [SerializeField]
    public GameObject button;
    public GameObject prograssBar;
    public Slider progress;
    public GameObject text;

    public void LoadPlayScene()
    {
        button.SetActive(false);
        prograssBar.SetActive(true);
        text.SetActive(true);
        StartCoroutine(LoadingScene());
    }

    IEnumerator LoadingScene()
    {
        yield return null;

        AsyncOperation op = SceneManager.LoadSceneAsync("SampleScene");
        op.allowSceneActivation = false;

        while (!op.isDone)
        {
            yield return null;

            if (op.progress < 0.9f)
            {
                progress.value = op.progress;
            }
            else
            {
                progress.value = 1.0f;

                if ( progress.value == 1.0f)
                {
                    op.allowSceneActivation = true;
                    yield break;
                }
            }
        }
    }
}
