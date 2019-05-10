using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopSound : MonoBehaviour {

	// Use this for initialization
	//public AudioClip _sound;
	 //AudioSource _source;
	public GameObject _collider;
	void Start () {
		//gameObject.GetComponent<AudioSource> ().playOnAwake = true;
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision testCol)
	{
		if (testCol.gameObject == _collider)
		{
			gameObject.GetComponent<AudioSource> ().Play ();
		}

	}
}