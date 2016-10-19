using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    //Variablen
    public Vector3 jumpForce = new Vector3(0, 300, 0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        jump();
	}

    void jump() {
        if (Input.GetKeyDown("space")) {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().AddForce(jumpForce);
        }
    }
}
