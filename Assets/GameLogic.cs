using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {
	public GameObject playerSelection1;
	public GameObject playerSelection2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Processes Player Selection
	public void PlayerSelection(GameObject column) {
		Debug.Log ("Clicked on a column: "+ column.ToString());

		// Player hasn't made a choice yet, so this will set player's first choice. 
		if (playerSelection1 == null) {
			Debug.Log("First column selected");
			playerSelection1 = column;
			return;
			// Add some indicator or visual/auditory feedback for player. 
		} 

		// Add a check to see if their first choice is the same as their second. If so, unselect all columns. 
		if (column.ToString().Equals(playerSelection1.ToString())) {
			Debug.Log("Columns match. Unselecting the column.");
			ResetSelections ();
			return;
		}

		// Player has selected first choice already and needs to select second choice to swap.
		if (playerSelection1 != null) {
			Debug.Log("Selecting the second column.");
			playerSelection2 = column;
			// Swap columns
			// Look for matches and tally score.
			ResetSelections();
			return;
		}
			
		// Update score.
	}

	private void ResetSelections() {
		playerSelection1 = null;
		playerSelection2 = null;
	}

}
