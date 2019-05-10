using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGate : MonoBehaviour {

	public GameObject _destroyedObject;
	public GameObject _collisionObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision testCol)
	{
		if (testCol.gameObject == _collisionObject)
		{
			Destroy (_destroyedObject);
		}

	}
}
