using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    //Variable
    public Vector3 velocity = new Vector3(-4, 0, 0);

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = velocity;

    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
