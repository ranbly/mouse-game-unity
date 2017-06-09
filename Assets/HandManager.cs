using UnityEngine;
using System.Collections;

public class HandManager : MonoBehaviour {

	public GameObject sourcePreFab; // Original Game Object
	public Canvas canvas;

	// Use this for initialization
	void Start () {
		InvokeRepeating("MakeHand", 2, Random.Range(1,2));
	}

	// Update is called once per frame
	void Update () {

	}


	void MakeHand(){
		for (int i = 0; i < Random.Range(0,1); i++) {
			int posy = Random.Range (-330, -331);

			GameObject go = Instantiate (sourcePreFab, new Vector3 (0, posy, 0), Quaternion.identity) as GameObject;
			go.transform.SetParent (canvas.transform, false);

			Destroy (go, 30);
		}
	}
}