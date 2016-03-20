using UnityEngine;
using System.Collections;

public class transferStage : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnCollisionEnter(Collision col) {
		Debug.Log ("Collision Detected");
		if (col.transform.name == "Player") {
			Debug.Log("Transfer Stage!");
			if (transform.name == "bunkerExit") {
				Application.LoadLevel("blah");
			} else {
				Application.LoadLevel("bunker");
			}
		}
	}
}
