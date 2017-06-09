using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mouse : MonoBehaviour {

	public float speed = 6;
	private int score = 0;

	private Text scoreGameObject;

	// Use this for initialization
	void Start () {
		scoreGameObject = GameObject.FindGameObjectWithTag ("score").GetComponent<Text> ();	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3 (Input.GetAxis ("Horizontal"), 0,0);
		transform.position += move * speed * Time.deltaTime;
	}

	void OnTriggerEnter2D(Collider2D coll) {
		print ("trigger enter " + coll.gameObject.tag);

		if (coll.gameObject.tag == "food") {
			Destroy (coll.gameObject);		
			score += 10;

			this.UpdateScore ();
		}
	
		if (coll.gameObject.tag == "trash") {
			Destroy (coll.gameObject);
			score -= 50;

			this.UpdateScore ();
		}

		if (coll.gameObject.tag == "jewelry") {
			Destroy (coll.gameObject);
			print ("get jewelry");
			score += 100;

			this.UpdateScore ();
		}

		if (coll.gameObject.tag == "hand") {
			Application.LoadLevel("intro");
		}

		if (score < 0) {
			Application.LoadLevel("intro");
		}
	}

	private void UpdateScore() {
		scoreGameObject.text = score.ToString ();
	}
}