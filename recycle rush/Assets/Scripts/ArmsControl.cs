using UnityEngine;
using System.Collections;

public class ArmsControl : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		movement ();
		if (Input.GetKey(KeyCode.R)){Application.LoadLevel("Playfield"); }

	}
	public void movement(){
		transform.Translate (Vector3.down * (Input.GetAxis("Elevator control")*2) * Time.deltaTime);
		if (Input.GetKey (KeyCode.UpArrow)) {transform.Translate((Vector3.up * .7f) * Time.deltaTime);}
		if (Input.GetKey (KeyCode.DownArrow)) {transform.Translate((Vector3.down * .7f) * Time.deltaTime);}

		Vector3 myPosition = transform.position;


		if (myPosition.y >=1.313642){
			transform.Translate ((Vector3.down /5));

		}
		if (myPosition.y< -0.6700794){
			transform.Translate ((Vector3.up /5));

		}

		//Debug.Log (myPosition);
		//utransform.Translate (Vector3.down * (Input.GetAxis("Elevator control2")*2) * Time.deltaTime);
	}

}
