using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Trash : MonoBehaviour {

	public Sprite[] sprites;

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().sprite = sprites [Random.Range (0, sprites.Length)];
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (0, -2 * Time.deltaTime, 0);
	}
}
