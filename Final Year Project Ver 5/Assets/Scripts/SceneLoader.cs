using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public float delayBeforeLoading = 35f;
    public float timeElapsed;

    void Update()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadOptionsScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadCreditScene()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadLevelSelectionScene()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadLevelOneCutScene()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadLevelOne()
    {
        SceneManager.LoadScene(5);
    }





}
