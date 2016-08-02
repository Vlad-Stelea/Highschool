using UnityEngine;
using System.Collections;

public class bluescore : MonoBehaviour {


	 
	private double Trussheight = 5.151896;
	private double TrussX1 = 0.3292522;
	private double TrussX2 = 1.027188;
	private double TrussZ1 = -15.86977;
	private double TrussZ2 = 15.97725;
	//high goal

	private double Highgoaly1 = 6.168222;
	private double Highgoaly2 = 9.27952;
	private double Highgoalx = 26.59059;
	private double Highgoalx2 = 26.9;
	private double Highgoalz1 = 11.91383;
	private double Highgoalz2 = 0.2410882;
	private double Highgoalz3 = -12.15766;

	//Scoreboard
	public GUIText ScoreText;
	public int score = 0;

	// Use this for initialization
	void Start () {
		UpdateScore ();


	}
	public Rigidbody blueball;
	public Transform bluespawn;


	
	void Update () {

				if (blueball.position.x > TrussX1 && blueball.position.x < TrussX2 && blueball.position.y > Trussheight && blueball.position.z < TrussZ2 && blueball.position.z > TrussZ1) {


			score = score + 10;			
								}

		if (blueball.position.x > Highgoalx && blueball.position.x < Highgoalx2 && blueball.position.y > Highgoaly1 && blueball.position.y < Highgoaly2 && blueball.position.z < Highgoalz1  && blueball.position.z > Highgoalz3) {
						score = score + 10;	
			Instantiate (blueball, bluespawn.position, bluespawn.rotation);
			Destroy (gameObject);

							}

				}


		

	void OnCollisionEnter (Collision collision ) {
		
				if (collision.gameObject.name == ("blue low goal")) {
						score = score + 1;
						Instantiate (blueball, bluespawn.position, bluespawn.rotation);
						Destroy (gameObject);

				
				}
		}

		void OnCollisionStay(Collision collision) {
			if (collision.gameObject.name == ("Respawnblue")) {
				
				Instantiate (blueball, bluespawn.position, bluespawn.rotation);
				Destroy (gameObject);
				
				
			}

		}

		
			
	void UpdateScore() {
		ScoreText.text = "" + score;

	}

						
				
	

		
		
	
	void FixedUpdate () {
		Debug.Log (score);
	}
}


