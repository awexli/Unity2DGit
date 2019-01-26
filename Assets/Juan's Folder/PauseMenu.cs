﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseUI;

    private bool paused = false;

    void Start(){
    	PauseUI.SetActive(false);
    }

    void Update(){
    	if(Input.GetButtonDown("Pause"))
    		paused=!paused;
    
    	if(paused)
    		PauseUI.SetActive(true);
    		Time.timeScale=0; //sets time to zero so freezes game

    	if(!paused)
    		PauseUI.SetActive(false);
    		Time.timeScale=1; //sets time back to normal if .number will do slowmo
    }	

    public void Resume(){
    	paused=false;
    }

    public void quitCurrentLevel(){
    	SceneManager.LoadScene(0);
    }
}
