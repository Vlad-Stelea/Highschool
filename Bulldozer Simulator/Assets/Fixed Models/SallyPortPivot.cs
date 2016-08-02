using UnityEngine;
using System.Collections;

public class SallyPortPivot : MonoBehaviour {

    Vector3 vec;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        vec = transform.eulerAngles;
        if (vec.y >90) {
            transform.Rotate(Vector3.forward * 5 * Time.deltaTime);
        }
	}
}
