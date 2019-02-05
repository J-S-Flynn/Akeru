
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
		manageState(); 
	}

	private void manageState() {

		var nextState = currentState.getNextState();

		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			currentState = nextState[0]; 
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2)) {
			currentState = nextState[1];
		}
		

		textField.text = currentState.getStoryText(); 
	}
	
}
