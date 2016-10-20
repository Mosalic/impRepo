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
        Jump();
        OffScreenCheck();
	}

    //Player jumps
    void Jump() {
        if (Input.GetKeyDown("space")) {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().AddForce(jumpForce);
        }
    }

    //checks if player is in screen
    void OffScreenCheck() {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.y > Screen.height || screenPos.y < 0) {
            Die(); 
        }
    }

    // checks collision
    void OnCollisionEnter(Collision col) {
        Die();
    }

    //player dies, game restarts
    void Die() {
        Application.LoadLevel(Application.loadedLevel);
    }
}
