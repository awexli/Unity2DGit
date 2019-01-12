using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GController : MonoBehaviour
{
    public GameObject heart1, heart2, heart3;
    //public GameObject ExtraLife, MiniPlayer, LargePlayer;
    public static int health;
    public static bool resetOption = false;
    //public Transform ExtraLifeSpawn, MiniSpawn, LargeSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 4)
            health = 4;
        
        switch(health)
        {
            case 4:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                //shieldheart1.gameObject.SetActive(true);
                break;

            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                //shieldheart1.gameObject.SetActive(false);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;

        }
    }
}
