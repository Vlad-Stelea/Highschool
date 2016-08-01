using UnityEngine;
using System.Collections;

public class AnimatorControl : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		animationC();
	
	}
	public void animationC(){
		if (Input.GetButton ("CloseGrip") || Input.GetKey(KeyCode.LeftControl)) {
			anim.SetBool("Close", true);
			anim.SetBool("Open", false);
		}
		if (Input.GetButton ("openGrip")|| Input.GetKey(KeyCode.LeftAlt)) {
			anim.SetBool("Open", true);	
			anim.SetBool("Close", false);
		}
	}
}
