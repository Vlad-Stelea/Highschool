using UnityEngine;
using System.Collections;

public class DriveTrain : MonoBehaviour {
	public float speed;
	public float rSpeed;

	//public float speed =5;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		/*float x = Input.GetAxis("X");
		float y= Input.GetAxis("Y");
		float z = Input.GetAxis("Z");*/
		//Movement ();


	
	}
	/*public float X(){
		return Input.GetAxis("X");
	}
	public float Y(){
		return Input.GetAxis("Y");
	}
	public float Z(){
		return Input.GetAxis("Z");
	}
*/
	void OnCollisionEnter(Collision col) {
		
		if (col.gameObject.tag == "Wall"){
				
			if(Input.GetKey(KeyCode.W)||Input.GetAxis("Y") < 0){
				transform.Translate(Vector3.left*speed/50);
			}
			if (Input.GetKey(KeyCode.S)||Input.GetAxis("Y") > 0){
				transform.Translate(Vector3.right*speed/50);
			}
			if (Input.GetKey(KeyCode.D)||Input.GetAxis("X") > 0){
				transform.Translate(Vector3.forward*speed/50);
			}
			if (Input.GetKey(KeyCode.A)||Input.GetAxis("X") < 0){
				transform.Translate(Vector3.back*speed/50);
			}

			
		}
		
	}


	void OnCollisionStay(Collision col){
		//int count = 0;
		speed = 2.3f;
		rSpeed = 100;
		//Vector3 myPosition = transform.position;

		/*if(myPosition.x >= -0.88f){
			float y = myPosition.y;
			float z = myPosition.z;
			//myPosition.Set(-1.462901f,y,z);
			transform.Translate(Vector3.left * .2f);
			
		}*/

		/*if (col.gameObject.tag == "Wall"){
			speed= -speed*3;

		}*/


						if (Input.GetButton ("half")) {
								speed *= .5f;
			rSpeed *=.5f;
						}
						if (Input.GetButton ("quarter")) {
						speed *= .25f;
						rSpeed *=.25f;
				} else {
						speed = 2.3f;
						rSpeed = 100f;
				}
		//if (Input.GetAxis ("Z") == null) {
						transform.Translate (Vector3.back * (Input.GetAxis ("X")) * speed * Time.deltaTime);
						transform.Translate (Vector3.left * (Input.GetAxis ("Y")) * speed * Time.deltaTime);
						transform.Rotate (Vector3.up * (Input.GetAxis ("Z") * 50) * speed * Time.deltaTime);
						//Debug.Log (Input.GetAxis ("Y"));
			//	}
						if (Input.GetKey (KeyCode.W)) {
								transform.Translate (Vector3.right * speed * Time.deltaTime);
						}
						if (Input.GetKey (KeyCode.S)) {
								transform.Translate (Vector3.left * speed * Time.deltaTime);
						}
						if (Input.GetKey (KeyCode.A)) {
								transform.Translate (Vector3.forward * speed * Time.deltaTime);
						}
						if (Input.GetKey (KeyCode.D)) {
								transform.Translate (Vector3.back * speed * Time.deltaTime);
						}
						if (Input.GetKey (KeyCode.E)) {
								transform.Rotate (Vector3.up * rSpeed * Time.deltaTime);
						}
						if (Input.GetKey (KeyCode.Q)) {
								transform.Rotate (Vector3.down * rSpeed * Time.deltaTime);
						}

		//count++;

		//Debug.Log (count);	

		

	}
}
