using UnityEngine;
using System.Collections;

public class Pivot : MonoBehaviour {

    // Use this for initialization
    Vector3 rotations;
    Vector3 initialRotations = new Vector3(270f,0f,0f);
     Vector3 com;
    public Rigidbody rb;
    
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = com;
        
	}
    void rotatateToPosition() {

    }
}
