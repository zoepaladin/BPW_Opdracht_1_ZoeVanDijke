using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour 
{
	public int ScoreValue = 1;

	// Use this for initialization
	void Start () 
	{

	}

	void OnCollisionEnter(Collision collision)
	{
		GameObject enemy = collision.gameObject;
		if (enemy.name == "GlowyBall") 
		{
			ScoreManager.score += ScoreValue;
			Destroy (enemy);
		}
	}

	// Update is called once per frame
	void Update () 
	{

	}
}

