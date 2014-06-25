using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public Transform Camera;
	public Transform Light;
	public int score;
	public bool hasWon = false;
	public bool isPaused = false;
	public bool hasFallen = false;

	// Use this for initialization
	void Start () {
		score = 0;
		hasWon = false;
		isPaused = false;
		hasFallen = false;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.W)) {
		rigidbody.AddForce (Vector3.forward * 10);
		}
		if(Input.GetKey (KeyCode.S)) {
			rigidbody.AddForce (Vector3.back * 10);
		}
		if(Input.GetKey (KeyCode.A)) {
			rigidbody.AddForce (Vector3.left * 10);
		}
		if(Input.GetKey (KeyCode.D)) {
			rigidbody.AddForce (Vector3.right * 10);
		}
		if(Input.GetKey (KeyCode.Space)) {
			if(transform.position.y < 1) {
				rigidbody.AddForce (Vector3.up * 200);
			}
		}

		Light.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z - 1);
		Camera.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z - 2);

		if(transform.position.y < -5) {
			hasFallen = true;
		}
	}
	void OnGUI() {
		GUI.Label (new Rect(10, 10, 100, 100), "Score = " + score);

		if(isPaused) {
			if(GUI.Button(new Rect(100, 100, 300, 100), "Unpause Game")) {
				Pause ();
				Debug.Log ("User has unpaused the game");
			}
			if(GUI.Button (new Rect(100, 210, 300, 100), "Quit game?")) {
				Application.Quit();
			}
		}
		if(hasWon && !isPaused) {
			if(GUI.Button (new Rect(100, 100, 300, 100), "Advance to next level")) {
				//Application.LoadLevel();
			}
			if(GUI.Button (new Rect(100, 210, 300, 100), "Quit game?")) {
				Application.Quit();
			}
		}
		if(hasFallen) {
			if(GUI.Button(new Rect(100, 100, 300, 100), "Retry?")) {
				Debug.Log ("User has clicked retry");
				transform.position = new Vector3(1, 2, -2);
				hasFallen = false;
				score = score - 1;
			}
			if(GUI.Button (new Rect(100, 210, 300, 100), "Quit game?")) {
				Application.Quit();
			}
		}
	}

	void OnTriggerEnter() {
		Debug.Log ("You win!");
		hasWon = true;
		score++;
	}
	void Pause() {
		if(Input.GetKey (KeyCode.Escape)) {
			if(isPaused) {
				Time.timeScale = 1;
				Debug.Log ("Application unpaused");
				isPaused = false;
			} else if (!isPaused) {
				Time.timeScale = 0;
				Debug.Log ("Application paused");
				isPaused = true;
			}
		}
	}
}
