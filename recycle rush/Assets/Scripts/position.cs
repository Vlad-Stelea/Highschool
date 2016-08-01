using UnityEngine;
using System.Collections;

public class position : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float speed = .01f;
		Vector3 myPosition = transform.position;
		if (myPosition.y <= 0.141747){
			transform.Translate (Vector3.up *speed);

		}
		if (myPosition.y >= 0.27806){
			transform.Translate (Vector3.down * speed);
			
		}
	}
}
