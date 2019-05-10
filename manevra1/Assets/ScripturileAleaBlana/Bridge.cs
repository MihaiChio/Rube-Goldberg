using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour {

	public GameObject _secondTarget;
	public GameObject _collider;
	Rigidbody _firstObject;
	Rigidbody _secondObject;


	// Use this for initialization
	void Start () 
	{
		_firstObject = gameObject.GetComponent<Rigidbody> ();
		_secondObject = _secondTarget.gameObject.GetComponent<Rigidbody> ();
	}

	void OnCollisionEnter(Collision _object)
	{
		if (_object.gameObject == _collider) 
		{
			_firstObject.isKinematic = false;
			_secondObject.isKinematic = false;
		}

	}

}
