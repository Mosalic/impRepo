using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    //Variablen
    public Vector2 jumpForce = new Vector2(0, 300);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        jump();
	}

    void jump() {
        if (Input.GetKeyDown("space")) {
            GetComponent<Rigidbody>().velocity = Vector2.zero;
            GetComponent<Rigidbody>().AddForce(jumpForce);
        }
    }
}
