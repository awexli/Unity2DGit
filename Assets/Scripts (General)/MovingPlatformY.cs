using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformY : MonoBehaviour
{
    float mvspeed = 3f;
    bool moveUp = true;
    bool moving = false;
    public float current_position; // enter current x position of platform
   
    // Update is called once per frame
    void FixedUpdate()
    {
       
        if (transform.position.y > (current_position + 5))
        {
            moveUp = false;
        }
        if (transform.position.y < (current_position))
        {
            moveUp = true;
        }

        if (moveUp)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + mvspeed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - mvspeed * Time.deltaTime);
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
