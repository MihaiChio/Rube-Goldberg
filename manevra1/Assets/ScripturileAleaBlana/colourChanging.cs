using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourChanging : MonoBehaviour {
	public GameObject _sphere;
	Rigidbody _body;
	public Color32 _colour;
	public GameObject _target;

	void Start()
	{
		_body = _target.GetComponent<Rigidbody> ();
		_colour = new Color32 (0, 0, 0, 1);
	}
    void OnCollisionEnter(Collision testCol)
    {
        if (testCol.gameObject == _sphere)
		{
            gameObject.GetComponent<Renderer> ().material.color = _colour;
			_body.isKinematic = false;
        }

    }
}
