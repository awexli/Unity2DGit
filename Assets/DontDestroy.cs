using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    GameObject[] objs;
   

    void Awake()
    {


        objs = GameObject.FindGameObjectsWithTag("Restart&NextLvl");
        

        if (objs.Length > 2)
        {
            
            Destroy(this.gameObject);
            Debug.Log("Sounds from previous scene destroyed");
          
            
            
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
       
        Debug.Log("Bruh loaded");
    }


}

