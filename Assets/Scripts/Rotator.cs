using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	// Update is called once per frame, does not require use of forces
	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);	//multiplied by Time.deltaTime to make the rotation smooth and frame-rate independent
	}
}
