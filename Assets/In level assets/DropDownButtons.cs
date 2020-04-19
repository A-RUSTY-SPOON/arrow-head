﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DropDownButtons : MonoBehaviour
{
    public GameObject BackButton;
    public GameObject ExitButton;
    public static bool GameIsPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        Resume();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        BackButton.SetActive(false);
        ExitButton.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        BackButton.SetActive(true);
        ExitButton.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void GoBack()
    {
        SceneManager.LoadScene("Level Selector");
    }

    public void Exit()
    {
        
    }
}
