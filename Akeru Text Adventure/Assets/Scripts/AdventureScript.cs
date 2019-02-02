
using UnityEngine;
using UnityEngine.UI;

public class AdventureScript : MonoBehaviour {

	[SerializeField] private Text textField;

	[SerializeField] private State startingState;

	private State currentState; 
	// Use this for initialization
	void Start () {

		currentState = startingState; 
		

		textField.text = currentState.getStoryText(); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
}
