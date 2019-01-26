using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour
{
	private Rigidbody2D rb2d;
	
	bool onWall = false;
	public Transform wallCheck;
	public float wallRadius = 0.5f;
	public LayerMask whatIsWall;
	
	public float jumpforce = 5f;
	
	public AudioSource jumpSound;
	
    // Start is called before the first frame update
    void Start()
    {
		rb2d = GetComponent<Rigidbody2D>();
		
    }
	
    // Update is called once per frame
    void Update()
    {
		
		if (Input.GetKeyDown(KeyCode.UpArrow) && onWall == true)
        {
			jumpSound.Play();
            rb2d.velocity = Vector2.up * jumpforce;
        }
    }
	
	void FixedUpdate()
	{
		onWall = Physics2D.OverlapCircle(wallCheck.position, wallRadius, whatIsWall);
	}
	
}
