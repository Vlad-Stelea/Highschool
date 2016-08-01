using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		//GameObject child = gameObject.tag ("gamepiece");
	}
	void OnCollisionStay(Collision col){
		if (col.gameObject.tag == "gamepiece" && anim.GetBool("Close") == true){
			col.transform.parent = transform;

		}
		if (anim.GetBool("Open") == true){
			col.transform.parent = null;

		}

	
	}
	void OnCollisionExit(Collision col){
				if (col.gameObject.tag == "gamepiece") {
						col.transform.parent = null;

				}
	
		}
	
	// Update is called once per frame
	void Update () {
	
	}
}
