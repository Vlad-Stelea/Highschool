using UnityEngine;
using System.Collections;

public class Seconds : MonoBehaviour {

	public GUIText SecondsGui;
	public float SecondsFloat = 90f;
	int SecondsInteger;

	// Use this for initialization
	void Start () {

		FixedUpdate ();

	}

	void Update () {

		SecondsFloat = SecondsFloat -= Time.deltaTime;
		if (SecondsFloat < 0) {
						Time.timeScale = 0;
			SecondsFloat = 0;
				}
		if (Input.GetKey (KeyCode.R)) {
			Time.timeScale = 1;
				}

		}

	
	// Update is called once per frame
	void FixedUpdate () {
		SecondsGui.text = "" + SecondsFloat;

	}
}
