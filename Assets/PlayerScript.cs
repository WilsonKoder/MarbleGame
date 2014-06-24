using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float score;

	// Use this for initialization
	void Start () {
		score = 0;
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

		/*
		if(Input.GetKey (KeyCode.P)) {
			if(Time.timeScale != 0f) {
				Time.timeScale = 0f;
			}
			if(Time.timeScale = 0f) {
				Time.timeScale = 1f;
			}
		}

		//rigidbody.AddForce(Vector3.back * Input.GetKey (KeyCode.S) * 10);
		//rigidbody.AddForce(Vector3.left * Input.GetKey (KeyCode.A) * 10);
		//rigidbody.AddForce(Vector3.right * Input.GetKey (KeyCode.D) * 10);
		if(Input.GetKey(KeyCode.W)) {
			//transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.1f);
			rigidbody.AddForce(Vector3.forward * Input.GetKey (KeyCode.W) * 10);
		}
		if(Input.GetKey(KeyCode.D)) {
			transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
		}
		if(Input.GetKey(KeyCode.A)) {
			transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
		}
		if(Input.GetKey(KeyCode.S)) {
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.1f);
		}
		if(transform.position.y < -5) {
			score = score - 1;
			transform.position = new Vector3(0.0f, 1.5f, transform.position.z);
		}
		if(Input.GetKeyDown (KeyCode.Space)) {
			transform.position = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
		} else if(Input.GetKeyUp (KeyCode.Space)) {
			transform.position = new Vector3(transform.position.x, transform.position.y - 0.2f, transform.position.z);
		}

		if(Input.GetKey (KeyCode.P)) {
			if(Time.timeScale != 0.0f) {
				Time.timeScale = 0.0f;
			}
			if(Time.timeScale = 0.0f) {
				Time.timeScale = 1.0f;
			}
		}
		*/
	}
	/*
	void OnGUI() {
		GUI.Label (new Rect(10, 10, 100, 100), "Score = " + score);

		if(Time.timeScale = 0.0f) {
			if(GUI.Button(new Rect(100, 100, 100, 100), "Unpause Game")) {
				Time.timeScale = 1.0f;
				Debug.Log ("User has paused the game");
			}
		}

	}
	*/
}
