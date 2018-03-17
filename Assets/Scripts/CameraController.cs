using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player; // references the players

	private Vector3 offset;		//holds our offset value

	// Use this for initialization
	void Start () {

		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is guaranteed to run after all procedures in Update have been performed
	void LateUpdate () {
		transform.position = player.transform.position + offset;	//as we move our player with the controls on the keyboard,
																	//before the camera displays before each frame,
																	//the camera is moved to a position that aligns with the player object, as if it were a child of the player object
	}
}
