using UnityEngine;
using System.Collections;

public class setDirection : MonoBehaviour {

	GameObject mainCam;

	// Use this for initialization
	void Start () {
		mainCam = GameObject.Find ("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion orientation = mainCam.transform.rotation;
		transform.rotation = orientation;
	}
}
