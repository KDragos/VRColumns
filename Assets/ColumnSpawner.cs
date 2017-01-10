using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour {
	public GameObject column;
	public GameObject[] matchableItems;
	public GameObject[] rows;

	private int numRows = 0;

	// Use this for initialization
	void Start () {
		CountChildren ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void CountChildren() {
		foreach (Transform child in column.transform) {
			if(child.tag.Equals("GridLocation")) {
				int number = (int) Random.Range (0, matchableItems.Length);
				GameObject matchableItem = (GameObject) Instantiate (matchableItems [number], child.transform.position, Quaternion.identity);
				matchableItem.transform.rotation = child.transform.rotation;
				matchableItem.transform.parent = child.transform;
				numRows++;
			}
		}
		Debug.Log ("numRows = " + numRows.ToString ());
		MoveDown ();
	}

	void MoveDown() {
		// if there's no empty spot below - stop.

		// Spawn a cube at spawner location. 

		// if emptySpotBelow - move spawned item down. and call the method again. 
//		GameObject objectToMove = (GameObject) rows[1].GetComponentInChildren<MatchableObject>();
//		iTween.MoveTo (objectToMove, rows[0].transform.position, 5f);



	}

	bool emptySpotBelow(int currentIndex) {
		// Get location of next row spot. 
		// Check to see if there's an item there.
			// if no item - return true
			// if there's an item there - return false.
		return true;
	}
}
