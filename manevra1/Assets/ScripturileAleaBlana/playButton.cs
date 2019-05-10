using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playButton : MonoBehaviour {

	// Use this for initialization
	public Button _button;
	void Start()
	{
		_button.onClick.AddListener (TaskOnClick);
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);

	}

	void TaskOnClick()
	{
		SceneManager.LoadScene("manevra");

	}


}
