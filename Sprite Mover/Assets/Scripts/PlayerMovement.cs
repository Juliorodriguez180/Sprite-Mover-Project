using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public SpriteRenderer sr;
	public Transform tf;

	// Use this for initialization
	void Start () {
		//Setting short things to call them later 0n
		sr = GetComponent<SpriteRenderer> ();
		tf = GetComponent<Transform> ();

	}

	// Update is called once per frame
	void Update () {


		//Change the Color of the ship if player presses space 
		if (Input.GetKey (KeyCode.Space)) {
			sr.color = Color.blue;
		} else {
			sr.color = Color.white;
		}

		//If Player presses the right arrow on keyboard, player will move right
		if (Input.GetKey (KeyCode.RightArrow)) {
			//move to the right 
			tf.position = tf.position + Vector3.right;
		}
		//If Player presses up arrow, player will move up
		if (Input.GetKey(KeyCode.UpArrow)){
			//move up
			tf.position = tf.position + Vector3.up;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			//move to the left
			tf.position = tf.position + Vector3.left;
		}
		//if player presses the down arrow key, player will move down
		if (Input.GetKey(KeyCode.DownArrow)){
			//move down
			tf.position = tf.position + Vector3.down;
		}
		//Quits the game if user presses the Escape Key
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit(); 
		}
		//Moves the player up One unit everytime the shift key is pressed 		
		if (Input.GetKey (KeyCode.LeftShift)) {
			transform.position += Vector3.up;
		}
		//breaks the game 
		if (Input.GetKey(KeyCode.P)){
			gameObject.SetActive (false);
			}
			
}
}