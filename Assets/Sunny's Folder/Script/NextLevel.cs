using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public AudioSource nextLevelSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           if (nextLevelSound == null)
            {
                Debug.Log("NextLevel sound should play");
                GameObject s = GameObject.FindGameObjectWithTag("NextLvl");
                nextLevelSound = s.GetComponent<AudioSource>();
                nextLevelSound.Play();

            }
            else
            {
                nextLevelSound.Play();
            }
                
                 SceneManager.LoadScene("Scene 2"); //loads scene based off string "nameofScene"
               // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loads scene based off of index scene
            }
        }

    }

