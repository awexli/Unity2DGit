using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectControl : MonoBehaviour
{
    public static SoundEffectControl Instance;

    void Awake()
    {
        this.InstantiateController();
    }

    private void InstantiateController()
    {
        if (Instance == null)
        {
           
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != Instance)
        {
            Destroy(this.gameObject);
           // Instantiate(Resources.Load("Bruh") as AudioSource);
            //Instantiate(Resources.Load("Yeet") as AudioSource);
        }
    }
}

