using UnityEngine;
using System.Collections;

public class Drive : MonoBehaviour {

    // Use this for initialization
    public float moveSpeed, joystickMoveSpeed;
    public int rotateSpeed, joystickRotateSpeed;
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        joysticks();
       if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.left * moveSpeed *Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.F))
        {
            flip();
        }
        if (Input.GetButton("HalfSpeed"))
        {
            joystickRotateSpeed = 50;
            joystickMoveSpeed = 1.35f;
        }
        else {
            joystickRotateSpeed = 100;
            joystickMoveSpeed = 2.7f;
        }
        if (Input.GetButton("Pause")) {
            Debug.Log("Start");
        }
    }
    void flip() {
        transform.eulerAngles = new Vector3(0,90,0);
    }
    void joysticks() {
        transform.Rotate(Vector3.down * (Input.GetAxis("Right") + Input.GetAxis("Left")) * joystickRotateSpeed * Time.deltaTime);
        transform.Translate(Vector3.left * (Input.GetAxis("Right") - Input.GetAxis("Left")) * joystickMoveSpeed * Time.deltaTime);
    }
}
