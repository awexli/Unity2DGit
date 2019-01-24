using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{

    public string DontDestroyTag;

    void Awake()
    {


        GameObject[] objs = GameObject.FindGameObjectsWithTag(DontDestroyTag);
        

        if (objs.Length > 1)
        {
            
                Destroy(this.gameObject);
                Debug.Log("Sounds from previous scene destroyed");
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
      
    }

    private void Start()
    {
       
        Debug.Log("Bruh loaded");
    }


}

