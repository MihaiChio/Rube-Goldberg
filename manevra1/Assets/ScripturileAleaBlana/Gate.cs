using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour {
	HingeJoint _joint;
	public GameObject _target;
	public GameObject _collider;
	// Use this for initialization
	void Start () 
	{
		_joint = _target.GetComponent<HingeJoint> ();
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision _col)
	{
		if (_col.gameObject == _collider) 
		{
			_joint.useMotor = true;
		}
	}
}
