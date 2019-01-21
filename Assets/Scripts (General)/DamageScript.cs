using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    void OnCollisionEnter2D(Collision2D col)
    {
        GameControlScript.health -= 1;
        if (col.transform.CompareTag("Player"))
            col.transform.position = spawnPoint.position;
    }
}
