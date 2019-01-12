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
	
	private int extraJumps;
	public int extraJumpsValue;
	
	public AudioSource jumpSound;
	
    // Start is called before the first frame update
    void Start()
    {
        extraJumps = extraJumpsValue;
		rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (onWall == true)
		{
			extraJumps = extraJumpsValue;
		}
		
		if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            rb2d.velocity = Vector2.up * jumpforce;
            jumpSound.Play();
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && onWall == true)
        {
            rb2d.velocity = Vector2.up * jumpforce;
            jumpSound.Play();
        }
    }
	
	void FixedUpdate()
	{
		onWall = Physics2D.OverlapCircle(wallCheck.position, wallRadius, whatIsWall);
	}
}
