using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
	{
		if (other.transform.tag == "Moving Platform")
		{
			transform.parent = other.transform;
		}
	}
	
	 void OnCollisionExit2D(Collision2D other)
	{
		if (other.transform.tag == "Moving Platform")
		{
			transform.parent = null;
		}
	}
}
