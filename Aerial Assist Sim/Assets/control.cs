using UnityEngine;
using System.Collections;


public class control : MonoBehaviour {
	public float movespeed = 10f;
	public float turnspeed = 500f;


	



void FixedUpdate () {


						if (Input.GetKey (KeyCode.W))
								transform.Translate (Vector3.right * movespeed * Time.deltaTime);
						if (Input.GetKey (KeyCode.S))
								transform.Translate (Vector3.left * movespeed * Time.deltaTime);
						if (Input.GetKey (KeyCode.A))
								transform.Rotate (Vector3.down * turnspeed * Time.deltaTime);
						if (Input.GetKey (KeyCode.D))
								transform.Rotate (Vector3.up * turnspeed * Time.deltaTime);
						
								
				}

		
		

}