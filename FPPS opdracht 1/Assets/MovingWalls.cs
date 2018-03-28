using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWalls : MonoBehaviour 
{

	public float delta = 10.0f;
	public float speed = 2.0f; 
	private Vector3 startPos;

	void Start () 
	{
		startPos = transform.position;
	}

	void Update () 
	{
		Vector3 v = startPos;
		v.z += delta * Mathf.Sin (Time.time * speed);
		transform.position = v;
	}
}


