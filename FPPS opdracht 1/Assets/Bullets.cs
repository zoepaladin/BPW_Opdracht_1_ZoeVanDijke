using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour 
{
	private AudioSource Twinkle;

	public AudioClip[] soundclips;
	public int ScoreValue = 1;
	// Use this for initialization
	void Start () 
	{
		Twinkle = (AudioSource)GetComponent (typeof(AudioSource));
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (1)) 
		{
			RaycastHit hitInfo;
			if (Physics.Raycast (transform.position + transform.forward, transform.forward, out hitInfo)) 
			{
				if (hitInfo.collider.gameObject.name == "GlowyBall") 
				{
					Destroy (hitInfo.collider.gameObject);
					ScoreManager.score += ScoreValue;
					print (ScoreManager.score);
					Twinkle.Play ();
				}
			}
		}
	}
}

