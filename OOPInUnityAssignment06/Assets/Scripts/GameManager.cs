﻿/*
 * (Noah Trillizio)
 * (Assignment 6)
 * (Controls the changing of the scenes)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager: Singleton<GameManager>
{
    public int score;

    public GameObject pauseMenu;

    // variable to keep track of what veariable we are on
    private string CurrentLevelName = string.Empty;

    //#region This code makes this class a Singleton
    //public static GameManager instance;

    //private void Awake()
    //{
    //    if (instance == null)
     //   {
    //        instance = this;
            // make sure this game manager persists across scenes
    //        DontDestroyOnLoad(gameObject);
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //        Debug.LogError("Trying to instantiate a second " + 
    //            "instance of singlton Game Manager");
    //    }
    //}
    //#endregion

    //method to load and unload scenes
    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if (ao == null)
        {
            Debug.LogError("[GameManager} Unable to load level " + levelName);
            return;
        }
        CurrentLevelName = levelName;
    }

    public void UnLoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null)
        {
            Debug.LogError("[GameManager} Unable to unload level " + levelName);
            return;
        }
    }

    public void UnloadCurrentLevel()
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);
        if (ao == null)
        {
            Debug.LogError("[GameManager} Unable to unload level " + CurrentLevelName);
            return;
        }
    }

    //pausing and unpausing

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void Unpause()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }
}
