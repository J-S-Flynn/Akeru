using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureScript : MonoBehaviour {

	[SerializeField] private Text textField; 
	// Use this for initialization
	void Start () {

		textField.text = "Welcome to the airship Akeru. One of the last ships capable of descending below the corona, the thick haze that now covers the surface. Nobody knows why" +
		                 " the Carona formed, some say it was the result of the experiments of men, other the natural defence of the planate below in response to man's disregard " +
		                 "for it. Whatever the case the one thing that everyone can agree on is that things lurk in the corona. Things only seen in the storybooks of old. Many ha" +
		                 "ve tried to venture below the corona, very few have returned. Now it is your turn Adventurer. Perhaps you will succeed where so many have failed. Good look. "; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
}
