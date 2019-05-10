using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDevice : MonoBehaviour {
	public GameObject _collider;
	public GameObject _target;
	Rigidbody _Trigger;
	// Use this for initialization
	void Start () {
		_Trigger = _target.gameObject.GetComponent<Rigidbody> ();
	}
	
	void OnCollisionEnter(Collision _object)
	{
		if (_object.gameObject == _collider) 
		{
			_Trigger.isKinematic = false;

		}

	}
}
