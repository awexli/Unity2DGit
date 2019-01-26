using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb2d;
    bool faceRight = true;

    Animator anim;
    public AudioSource jumpSound;
    public AudioSource restartSound;
    

    bool grounded = false;
    public Transform groundCheck;
    public float groundRadius = 0.5f;
    public LayerMask whatIsGround;

    public float jumpforce = 5f;

    private int extraJumps;
    public int extraJumpsValue;

    // Start is called before the first frame update
    void Start()
    {
        extraJumps = extraJumpsValue;
        rb2d = GetComponent<Rigidbody2D>();
       // anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (grounded == true)
        {
            extraJumps = extraJumpsValue;
        }

        

        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            rb2d.velocity = Vector2.up * jumpforce;
            jumpSound.Play();
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && grounded == true)
        {
            rb2d.velocity = Vector2.up * jumpforce;
            jumpSound.Play();
        }

        if(Input.GetKeyDown(KeyCode.R)){
            
            if (restartSound == null)
            {
                GameObject s = GameObject.FindGameObjectWithTag("Restart");
                restartSound = s.GetComponent<AudioSource>();
                restartSound.Play();

            }
            else
            {
                restartSound.Play();
            }
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //or whatever number your scene is
        }

    }

    void FixedUpdate()
    {
        //checks if grounded
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        //anim.SetBool("Ground", grounded);

        // get horizontal input
        float moveHorizontal = Input.GetAxis("Horizontal");
        //anim.SetFloat("Speed", Mathf.Abs(moveHorizontal));

        // need velocity to move in horizontal
        rb2d.velocity = new Vector2(moveHorizontal * speed, rb2d.velocity.y);


        if (moveHorizontal > 0 && !faceRight)
        {
            Flip();
        }
        else if (moveHorizontal < 0 && faceRight)
        {
            Flip();
        }

    }

    void Flip()
    {
        // face left instead
        faceRight = !faceRight;

        // get local axis
        Vector3 flipped = transform.localScale;

        // flip  onto x axis
        flipped.x *= -1;
        transform.localScale = flipped;
    }

    // for powerups; check each powerup tag that player collides into
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ExtraLife"))
        {
            GameControlScript.health += 1;
            Destroy(other.gameObject);
        }
        //
        if (other.CompareTag("Mini"))
        {
            Destroy(other.gameObject);
            StartCoroutine(miniTime());
        }

        if (other.CompareTag("Large"))
        {
            Destroy(other.gameObject);
            StartCoroutine(largeTime());
        }

    }

    
   
    IEnumerator miniTime()
    {
        // become mini for 30 seconds
        transform.localScale /= 2;
        speed = speed * 2;
        jumpforce *= 2;
        yield return new WaitForSeconds(30);
        // revert back to normal and avoids clipping through floor
        transform.position = new Vector2(transform.position.x, transform.position.y + 1); 
        transform.localScale *= 2;
        speed = speed / 2;
        jumpforce /= 2;
    }

    IEnumerator largeTime()
    {
        // become mini for 30 seconds
        transform.localScale *= 2;
        speed = speed / 2;
        yield return new WaitForSeconds(30);
        // revert back to normal and avoids clipping through floor
        transform.position = new Vector2(transform.position.x, transform.position.y + 1);
        transform.localScale /= 2;
        speed = speed * 2;
    }
}
