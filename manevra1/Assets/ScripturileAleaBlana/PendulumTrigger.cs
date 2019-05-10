using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumTrigger : MonoBehaviour {

	// Use this for initialization
	public GameObject _collider;
	Rigidbody _rigid;
	void Start () {
		_rigid = gameObject.GetComponent<Rigidbody> ();
	}

	void OnCollisionEnter(Collision _object)
	{
		if (_object.gameObject == _collider) 
		{
			_rigid.isKinematic = false;
		}
	}

}
