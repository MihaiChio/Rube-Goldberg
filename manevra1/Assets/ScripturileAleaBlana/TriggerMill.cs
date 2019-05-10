using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMill : MonoBehaviour {
	public GameObject _MillAttachement;
	public GameObject _collider;
	rotate _1st;
	rotate _2nd;
	// Use this for initialization
	void Start () {
		_1st = gameObject.GetComponent<rotate> ();
		_2nd = _MillAttachement.gameObject.GetComponent<rotate> ();
	}
	
	void OnCollisionEnter(Collision _test)
	{
		if (_test.gameObject == _collider) 
		{
			_1st.speed = -1;
			_2nd.speed = -1;
		}
	}
}
