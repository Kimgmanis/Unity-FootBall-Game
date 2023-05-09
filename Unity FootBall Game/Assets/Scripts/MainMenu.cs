using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Gets the current active scene +1 to index number; starts at 0 MainMenu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
        Debug.Log("Level2 loaded");
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
        Debug.Log("Level3 loaded");
    }

    public void QuitGame()
    {
        // Prints quit in unity console when toggled
        Debug.Log("Quit");
        Application.Quit();
    }
}
