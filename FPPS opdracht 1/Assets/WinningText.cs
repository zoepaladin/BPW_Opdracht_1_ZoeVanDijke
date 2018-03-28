using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinningText : MonoBehaviour 
{
	public Text WinText;

	// Use this for initialization
	void Start () 
	{
		WinText = GetComponent<Text> ();
		WinText.text = "";
	}
	
	// Update is called once per frame
	void Update () 
	{
		GameObject Scoretext = GameObject.Find("ScoreText");
		ScoreManager scoreManager = Scoretext.GetComponent<ScoreManager>();
		if (ScoreManager.score >= 17) 
		{
			WinText.text = "Winner!!";
		}
	}
}
