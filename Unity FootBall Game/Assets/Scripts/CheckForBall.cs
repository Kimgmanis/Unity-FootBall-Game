using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckForBall : MonoBehaviour
{
    public static bool GameIsPaused = false;

    [SerializeField]
    public GameObject winMenuUI;
    [SerializeField]
    public GameObject football;
    [SerializeField]
    public TextMeshProUGUI score;
    [SerializeField]
    public AudioSource winAudio;
    [SerializeField]
    public AudioSource startAudio;

    private int counter;

    private void Start()
    {
        Time.timeScale = 1f;
        resetCounter();
        startAudio.Play();
    }

    private void Update()
    {
        if (counter == 1)
        {
            win();
            winAudio.Play();
        }
    }

    void win()
    {
        winMenuUI.SetActive(true);
        Time.timeScale = 0f; // Stops time
        GameIsPaused = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (football != null)
        {
            addCounter();
        }
    }

    private void addCounter()
    {
        counter ++;
        score.text = counter.ToString();
    }

    private void resetCounter()
    {
        counter = 0;
    }
}
