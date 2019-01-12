using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]float speed = 5f;
	[SerializeField]bool moveLeft = true;
	
	Transform t;
	SpriteRenderer sr;
	
	void Start()
	{
		projectLeft(moveLeft);
	}
	
	void Awake()
	{
		t = transform;
		sr = GetComponent<SpriteRenderer>();
	}
	
	void Update()
	{
		if(moveLeft)
			t.Translate(Vector2.left * speed * Time.deltaTime);
		else
			t.Translate(Vector2.right * speed * Time.deltaTime);
	}
	
	public void projectLeft(bool dir)
	{
		moveLeft = dir;
		if(!dir)
			sr.flipX = true;
	}
	
}
