using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame(){ 
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); //loads scene based off of index scene
    	//SceneManager.LoadScene("SceneTwo"); //loads scene based off string "nameofScene"
    }

    public void quit(){ 
    	Application.Quit();
    }

    public void quitCurrentGame(){
    	SceneManager.LoadScene(0);
    }
}
