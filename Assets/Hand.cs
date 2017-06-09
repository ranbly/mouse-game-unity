using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (0, -2 * Time.deltaTime, 0);
		//transform.Translate (transform.position, -343.8, speed * Time.deltaTime);
		//transform.position = Vector3.Lerp (transform.position, -343.8 , speed * Time.deltaTime);
		transform.Translate (0, -2 * Time.deltaTime, 0);

		 

	}

	void OnCollisionEnter2D(Collision2D coll) {
		print ("hand collider");
		if (coll.gameObject.tag == "mouse") {
			//Application.LoadLevel ("intro");
		}
	}
}
