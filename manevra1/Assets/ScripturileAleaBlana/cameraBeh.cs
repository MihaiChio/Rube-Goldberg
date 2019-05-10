using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBeh : MonoBehaviour {

	[SerializeField] private Transform target;
	private Vector3 offset;
	void Start()
	{
		offset = target.position - transform.position;

	}
	// Use this for initialization
	void LateUpdate()
	{

		transform.position = target.position - offset;
		transform.LookAt (target);
	}
}
