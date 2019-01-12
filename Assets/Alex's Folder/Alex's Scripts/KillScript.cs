using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    void OnCollisionEnter2D(Collision2D col)
    {
        GController.health -= 1;
        if (col.transform.CompareTag("Player"))
            col.transform.position = spawnPoint.position;
    }

}
