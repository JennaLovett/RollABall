using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;

	public float speed;		//using a public variable because it can be accessed within the editor(inspector, specifically), which allows us to avoid reopening
							//the script every time we need to update the speed

	private int count;		//count of collected objects

	public Text countText;

	public Text winText;

	void Start() {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate() {		//called before performing any physics calculations
		float moveHorizontal = Input.GetAxis("Horizontal");		//grabs input from player based on keys on keyboard
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {	//called when our in-game player object first touches a trigger
		if (other.gameObject.CompareTag ("PickUp")) {	//deactivates game object when it has this tag
			other.gameObject.SetActive (false);
			count++;
			SetCountText ();
			if (count >= 12) {
				winText.text = "YOU WON!";
			}
		}
	}

	void SetCountText() {
		countText.text = "Count: " + count.ToString();
	}

}
