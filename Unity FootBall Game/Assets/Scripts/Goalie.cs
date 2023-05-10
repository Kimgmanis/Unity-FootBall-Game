using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goalie : MonoBehaviour
{
    public static bool GameIsPaused = false;
    [SerializeField]
    public GameObject loseMenuUI;
    [SerializeField]
    public GameObject football;

    private void OnTriggerEnter(Collider other)
    {
        if (football != null)
        {
            lose();
        }
    }

    void lose()
    {
        loseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Stops time
        GameIsPaused = true;
    }
}
