using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	bool PlayerEnter = false;

	void Update()
	{
		if (PlayerEnter)
		{
			if (Input.GetKey (KeyCode.E))
			{
				SceneManager.LoadScene ("First Floor");
			}
		}
	}

	void OnTriggerEnter(Collider someObject)
	{
		if(someObject.CompareTag("Player"))
		{
			PlayerEnter = true;
		}
	}

	void OnTriggerExit(Collider someObject)
	{
		if(someObject.CompareTag("Player"))
		{
			PlayerEnter = false;
		}
	}
}
