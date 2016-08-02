using UnityEngine;
using System.Collections;

public class animationcontrol : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> (); 
		
	}
	
	// Update is called once per frame
		 void Update () {
		if (Input.GetKeyDown(KeyCode.LeftShift))
		
			anim.SetBool("shiftbuttondown", true);

		if (Input.GetKeyUp (KeyCode.LeftShift))
						anim.SetBool ("shiftbuttondown", false);


		if (Input.GetKeyDown (KeyCode.LeftShift))
						anim.SetBool ("armsdownbool", true);

		if (Input.GetKeyDown (KeyCode.LeftControl))
						anim.SetBool ("ctrl", true);

		if (Input.GetKeyUp (KeyCode.LeftControl))
						anim.SetBool ("ctrl", false);

		if (Input.GetKeyDown (KeyCode.Z))
						anim.SetBool ("Z", true);

		if (Input.GetKeyUp (KeyCode.Z))
			anim.SetBool ("Z", false);

		if (Input.GetKey (KeyCode.Z)) 
						anim.SetBool ("shiftbuttondown", false);

		if (Input.GetKeyDown (KeyCode.Z)) 
			anim.SetBool ("armsdownbool", false);

		if (Input.GetKeyDown (KeyCode.Z))
						anim.SetBool ("shiftbuttondown", false);

		if (Input.GetKeyDown (KeyCode.Z))
						anim.SetBool ("X", false);


		if (Input.GetKeyDown (KeyCode.X))
						anim.SetBool ("X", true);

		if (Input.GetKeyDown (KeyCode.Space))
						anim.SetBool ("X", false);


		if (Input.GetKey (KeyCode.Space))
						anim.SetBool ("Space", true);

		if (Input.GetKeyUp (KeyCode.Space))
						anim.SetBool ("Space", false); 


		}
}
