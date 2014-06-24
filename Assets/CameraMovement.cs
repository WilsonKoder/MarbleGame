using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//This script will make the cameras height be equal to that of the sphere. 
		transform.position = new Vector3(player.position.x, player.position.y + 2f, player.position.z - 2f);
	}
}
