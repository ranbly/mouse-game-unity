using UnityEngine;
using System.Collections;

public class Cave : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		print ("cave collider");
		if (coll.gameObject.tag == "food") {
			Destroy (coll.gameObject);
		}
	}
}
