using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    public AudioSource deathSound;
    void OnCollisionEnter2D(Collision2D col)
    {
        GameControlScript.health -= 1;
        if (col.transform.CompareTag("Player"))
            deathSound.Play();
            col.transform.position = spawnPoint.position;
    }
}
