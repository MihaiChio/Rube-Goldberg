using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

	// Use this for initialization
	public float speed = 5.0f;
	// Update is called once per frame
	void Update () 
	{
		gameObject.transform.Rotate (0, speed,0);
	}
}
