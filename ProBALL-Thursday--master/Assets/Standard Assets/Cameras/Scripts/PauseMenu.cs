﻿using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;


public class PauseMenu : MonoBehaviour
{

    public GameObject PauseUI;

    private bool paused = false;

    void Start()
    {
        PauseUI.SetActive(false);
    }

    void Update()
    {

        if (Input.GetButtonDown("Pause"))
        {
            paused = !paused;
        }

        if (paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }

    }

    public void Resume()
    {
        paused = false;
    }

    public void Restart(string name)
    {
        SceneManager.LoadScene (name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
