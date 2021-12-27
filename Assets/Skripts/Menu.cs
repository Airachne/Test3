using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private XMLSerializer save;

    public void LoadGame()
    {
        Save();
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        // SceneManager.LoadScene("Menu");
        // Time.timeScale = 0f;
        SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
        AudioListener.pause = true;
        Destroy(GameObject.Find("EventSystem"));

    }

    public void UnLoadMenu()
    {
        Save();
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
    private void Save()
    {
        save = FindObjectOfType<XMLSerializer>();
         save.SaveSound();
        AudioListener.pause = false;
    }
}