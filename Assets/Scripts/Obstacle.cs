using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    //Variable
    public Vector3 velocity = new Vector3(-4, 0, 0);
    public float range = 4;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = velocity;
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);

    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
