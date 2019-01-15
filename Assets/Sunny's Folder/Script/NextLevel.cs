﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           // SceneManager.LoadScene("Scene 2"); //loads scene based off string "nameofScene"
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loads scene based off of index scene
        }

    }
}
