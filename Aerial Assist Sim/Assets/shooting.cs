using UnityEngine;
using System.Collections;



 class shooting : MonoBehaviour {
	public float forward = 100f;
	public float up = 70f;
	public float turnspeed = 400f;

	 //Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void OnCollisionStay(Collision collision) {
				if (collision.gameObject.name == ("blue robot")) {




						
						if (Input.GetKey (KeyCode.Space))
								rigidbody.AddForce (transform.right * forward);
						if (Input.GetKey (KeyCode.Space))
								rigidbody.AddForce (transform.up * up);
						
				}
		}
		void FixedUpdate (){

			if (Input.GetKey (KeyCode.A))
				transform.Rotate (Vector3.down * turnspeed * Time.deltaTime);
			if (Input.GetKey (KeyCode.D))
				transform.Rotate (Vector3.up * turnspeed * Time.deltaTime);
			
		

		
		



		}
	
	}

		



