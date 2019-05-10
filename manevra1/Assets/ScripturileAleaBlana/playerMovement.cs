using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public float speed;
	float deltaX;// Use this for initialization
	float deltaZ;

	void Start () {
		  speed = 0.2f;

	}
	
	// Update is called once per frame
	void Update () {
		deltaX = Input.GetAxis ("Horizontal") * speed;
		deltaZ = Input.GetAxis ("Vertical") * speed;
		print (Input.GetAxis ("Horizontal"));
		transform.Translate (deltaX, 0, deltaZ);
	}
}
