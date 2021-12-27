using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject button; // Видимость кнопки продолжить
    // Start is called before the first frame update
 /*   void Start()
    {
        Debug.Log("Начало");

        string lname = SceneManager.GetActiveScene().name;  // Значение имени активных сцен
        if (lname == "Game") // если сцена с игрой загружена
            button.SetActive(true); // включаем кнопку продолжить

    }
    public void OnApplicationQuit()
    {
        button.SetActive(false); // при выходе из игры делаем кнопку продолжить  невидимой
        Debug.Log("Выход!");
    }*/
}
