using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

    // Use this for initialization
    public GameObject obj;
    public GameObject loc;
    public GameObject launchLoc;
    GameObject newBall;
    public Rigidbody rb;
    bool inPossession;
    Vector3 vec;
    bool shouldMove = false;
    void Start() {
    }

    // Update is called once per frame
    void FixedUpdate() {
        // vec = transform.eulerAngles;
        // newBall.transform.eulerAngles = vec;
        if (inPossession) {
            newBall.GetComponent<Rigidbody>().velocity = Vector3.zero;
            newBall.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.X)&&inPossession) {
            
            newBall.transform.SetParent(null);
            newBall.transform.position = launchLoc.transform.position;
            moveBall();
            // rb.AddForce(transform.right *100);
            /*for (int i=0; i<5000;i++) {
                newBall.GetComponent<Rigidbody>().AddForce(transform.right * -.01f,ForceMode.VelocityChange);
                wait();
            }*/
            inPossession = false;
        }
        if (Input.GetAxis("Right Trigger") == 1 && inPossession)
        {

            newBall.transform.SetParent(null);
            newBall.transform.position = launchLoc.transform.position;
            moveBall();
            inPossession = false;
        }
        if (Input.GetButton("Right Back") && inPossession)
        {

            newBall.transform.SetParent(null);
            newBall.transform.position = launchLoc.transform.position;
            moveBall();
            inPossession = false;
        }
    }
    void moveBall() {
        newBall.GetComponent<Collider>().enabled = true;
        newBall.GetComponent<Rigidbody>().isKinematic = false;
        newBall.GetComponent<Rigidbody>().AddForce(transform.right * -10f);
    }
    IEnumerator wait() {
        yield return new WaitForSeconds(1f);
    }
    void OnCollisionStay(Collision col)
    {
        //Suck it up
        if (col.gameObject.tag == "Ball" && Input.GetKey(KeyCode.Space) &&!inPossession)
        {
            newBall = col.gameObject;
            newBall.GetComponent<Collider>().enabled = false;
            newBall.GetComponent<Rigidbody>().isKinematic = true;
            col.gameObject.transform.position = new Vector3(loc.transform.position.x, loc.transform.position.y, loc.transform.position.z);
            col.gameObject.transform.SetParent(loc.transform);
            col.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            col.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            inPossession = true;
            /*Destroy(col.gameObject);
           newBall =  (GameObject)Instantiate(obj,loc.transform.position,loc.transform.rotation);
           newBall.transform.SetParent(loc.transform);*/
        }
        if (col.gameObject.tag == "Ball" && Input.GetButton("Left Bumper") && !inPossession)
        {
            newBall = col.gameObject;
            newBall.GetComponent<Collider>().enabled = false;
            newBall.GetComponent<Rigidbody>().isKinematic = true;
            col.gameObject.transform.position = new Vector3(loc.transform.position.x, loc.transform.position.y, loc.transform.position.z);
            col.gameObject.transform.SetParent(loc.transform);
            col.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            col.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            inPossession = true;
            /*Destroy(col.gameObject);
           newBall =  (GameObject)Instantiate(obj,loc.transform.position,loc.transform.rotation);
           newBall.transform.SetParent(loc.transform);*/
        }


    }
}
