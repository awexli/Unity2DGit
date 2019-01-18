using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformX : MonoBehaviour
{
    float mvspeed = 3f;
    bool moveRight = true;
    bool moving = false;
    public float current_position; // enter current x position of platform
   
    // Update is called once per frame
    void Update()
    {
       
        if (transform.position.x > (current_position + 5))
        {
            moveRight = false;
        }
        if (transform.position.x < (current_position))
        {
            moveRight = true;
        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + mvspeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - mvspeed * Time.deltaTime, transform.position.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            {
            moving = true;
            collision.collider.transform.SetParent(transform);
            }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
            collision.collider.transform.SetParent(null);
        }
    }
}
