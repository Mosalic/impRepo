using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject pillars;
    int score = 0;

    // Use this for initialization
    void Start () {
		InvokeRepeating ("CreateObstacle", 1f, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI() {
        GUI.color = Color.black;
        GUILayout.Label("Score: " + score.ToString());
    }

	void CreateObstacle(){
		Instantiate (pillars);
        score++;
	}
}
