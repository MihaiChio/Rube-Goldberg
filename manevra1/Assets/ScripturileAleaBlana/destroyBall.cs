using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBall : MonoBehaviour {

    public GameObject _target;
	void Start () {
		
	}

    void OnCollisionEnter(Collision testCol)
    {
        if (testCol.gameObject == _target)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 1);
            Destroy(testCol.gameObject);
        }

    }
}
