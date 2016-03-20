using UnityEngine;
using System.Collections;

public class keepBreathing : MonoBehaviour {

	public ParticleSystem breather; 

	// Use this for initialization
	void Start () {
		StartCoroutine ("breathe");
		Debug.Log ("In Start!");
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator breathe() {
		while (true) {
			Debug.Log("In breathe!");
			breather.Simulate(0f, true, true);
			breather.Play();

			yield return new WaitForSeconds(1.5f);
			Debug.Log("Test!");
			breather.Stop();
			yield return new WaitForSeconds(3f);
		}
	}
}

