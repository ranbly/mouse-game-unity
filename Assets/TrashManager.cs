using UnityEngine;
using System.Collections;

public class TrashManager : MonoBehaviour {

	public GameObject sourcePreFab; // Original Game Object
	public Canvas canvas;

	// Use this for initialization
	void Start () {
		InvokeRepeating("MakeTrash", 0, 1);
	}

	// Update is called once per frame
	void Update () {

	}

	void MakeTrash(){
		for (int i = 0; i < Random.Range(0,3); i++) {
			int posy = Random.Range (-300, -315);

			GameObject go = Instantiate (sourcePreFab, new Vector3 (Random.Range (-705, -725), posy, 0), Quaternion.identity) as GameObject;
			go.transform.SetParent (canvas.transform, false);

			Destroy (go, 30);
		}
	}
}