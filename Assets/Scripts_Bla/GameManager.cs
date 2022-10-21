using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool GamePaused;
    public GameObject PauseMenu;


    public void LoadGameLevel()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }


        if (GamePaused == true)
        {
            Time.timeScale = 0;
            PauseMenu.SetActive(true);
        }
        else if (GamePaused == false)
        {
            Time.timeScale = 1;
            PauseMenu.SetActive(false);
        }
    }

    public void Pause()
    {
        if (GamePaused == false)
        {
            GamePaused = true;
        }
        else if (GamePaused == true)
        {
            GamePaused = false;
        }
    }



    public void QuitGame()
    {
        Application.Quit();
    }
}
