using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {
	// Use this for initialization
	void OnCollisionEnter(Collision testCol)
	{
		if (testCol.gameObject.name == "initialBox") 
		{
			//Destroy (testCol.gameObject);
		}

	}
}
