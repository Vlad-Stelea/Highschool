using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

    // Use this for initialization
    bool isPaused = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused) {
            Time.timeScale = 0;
            isPaused = true;
        }
       else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            Debug.Log("UnPause");
            Time.timeScale = 1;
            isPaused = false;
        }
    }
}
