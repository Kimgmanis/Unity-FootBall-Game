using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Gets the current active scene +1 to index number; starts at 0 MainMenu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        // Prints quit in unity console when toggled
        Debug.Log("Quit");
        Application.Quit();
    }
}
