﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// creates xMax, xMin, yMax, yMin variables for camera on specific levels.
// prevents camera from moving past these variables

[DisallowMultipleComponent]
public class CamClamp : MonoBehaviour {
	[SerializeField]Transform target;
	[SerializeField]float xMin = -1;
	[SerializeField]float xMax = 1;
	[SerializeField]float yMin = -1;
	[SerializeField]float yMax = 1;
	
	
	Transform t;
	
	void Awake ()
	{
		t = transform;
	}
	
	void LateUpdate()
	{
		float x = Mathf.Clamp(target.position.x, xMin, xMax);
		float y = Mathf.Clamp(target.position.y, yMin, yMax);
		t.position = new Vector3(x, y, t.position.z);
	}
	
}