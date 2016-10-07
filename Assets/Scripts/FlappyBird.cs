using UnityEngine;
using System.Collections;

public class FlappyBird : MonoBehaviour {
	public float jumpforce = 40f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		detectInput ();
	}

	void detectInput(){
		if (Input.GetKeyDown ("space")) {
			Debug.Log ("Button pressed");
			jump ();
		}
	}

	void jump(){
		gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 0f, 0f);
		gameObject.GetComponent<Rigidbody>().AddForce (new Vector3 (0f, jumpforce, 0f));
	}
}
