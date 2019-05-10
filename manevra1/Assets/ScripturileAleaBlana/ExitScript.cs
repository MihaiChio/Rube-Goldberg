using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitScript : MonoBehaviour {

	// Use this for initialization
	public Button _button;
	void Start()
	{
		_button.onClick.AddListener (OnClickEvent);
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);

	}

	void OnClickEvent()
	{

		UnityEditor.EditorApplication.isPlaying = false;
	}


}
