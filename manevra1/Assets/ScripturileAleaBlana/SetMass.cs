using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMass : MonoBehaviour {
	public GameObject _target;
	Rigidbody _body;
	// Use this for initialization
	void Start () {
		_body = gameObject.GetComponent<Rigidbody>();
	}
	
	void OnCollisionEnter(Collision _object)
	{
		if (_object.gameObject == _target) {

			_body.mass = 8;
		}
	}
}
