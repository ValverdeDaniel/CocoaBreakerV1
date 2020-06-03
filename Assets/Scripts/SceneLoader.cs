using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<GameSession>().ResetGame();
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
        FindObjectOfType<GameSession>().ResetGame();
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene(2);
        FindObjectOfType<GameSession>().ResetGame();
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene(3);
        FindObjectOfType<GameSession>().ResetGame();
    }
    public void LoadLevel4()
    {
        SceneManager.LoadScene(4);
        FindObjectOfType<GameSession>().ResetGame();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
