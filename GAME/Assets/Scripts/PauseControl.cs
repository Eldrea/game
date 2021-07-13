using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseControl : MonoBehaviour
{
    public GameObject mainMenu;
    public static bool gameIsPaused;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
        }

        if (gameIsPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
        Time.timeScale = 0f;
        mainMenu.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1;
        mainMenu.SetActive(false);
        gameIsPaused = false;
    }

    public void BackToMainMenu()
    {
        gameIsPaused = !gameIsPaused;
        SceneManager.LoadScene(0);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameIsPaused = !gameIsPaused;
    }
}
