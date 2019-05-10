using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalPan : MonoBehaviour {

	public GameObject _collider;
	// Use this for initialization

	void OnCollisionEnter(Collision _object)
	{
		if (_object.gameObject == _collider) {

			SceneManager.LoadScene ("egg");
		}

	}
}
