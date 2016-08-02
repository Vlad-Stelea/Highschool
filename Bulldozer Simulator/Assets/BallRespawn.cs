using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallRespawn : MonoBehaviour {
    public GameObject respawn1, respawn2, respawn3, respawn4, respawn5;
    public Text scoreText;
    GameObject[] respawn;
    int[] used;
    int score = 0;
    // Use this for initialization
    void Start() {
        for (int i =0; i<5;i++) {
            used[i] = 1;
        }
        respawn[0] = respawn1;
        respawn[1] = respawn2;
        respawn[2] = respawn3;
        respawn[3] = respawn4;
        respawn[4] = respawn5;
        
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;
	}
    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Ball") {
            Debug.Log("+1");
            Destroy(col.gameObject);
            Instantiate(col.gameObject,findUsed().transform.position, findUsed().transform.rotation);
            score+=2;
            Debug.Log(score);
        }
    }
    GameObject findUsed() {
        return respawn1;
    }
}
