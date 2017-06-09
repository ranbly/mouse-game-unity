using UnityEngine;
using System.Collections;

public class NextStage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Next() {
		print ("btn clicked");
		Application.LoadLevel ("scene01");
	}
}
