using UnityEngine;
using System.Collections;

public class Robotschooter : MonoBehaviour {
	public Mesh blueball;
	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionStay(Collision collision) {
		if (collision.gameObject.name == ("blue ball")) {
			if (Input.GetKey(KeyCode.Space)){}
				//rigidbody.AddForce ();
			
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
