using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OCDoor : MonoBehaviour 
{
	//private Animator _animator = null;

	private Animation _animator;
	public bool doorOpen;
	public AnimationClip Open;
	public AnimationClip Close;

	void Start()
	{
		_animator = gameObject.GetComponent<Animation> ();
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.E)) 
		{
			OpenDoor ();		
		}
	}

	void OpenDoor()
	{
		if (doorOpen == true) 
		{
			gameObject.GetComponent<Animation>().Play ("Open");
			doorOpen = false;
		} 
		else 
		{
			gameObject.GetComponent<Animation>().Play ("Close");
			doorOpen = true;
		}
	}
}
/*
	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Ivanoffee" & Input.GetKeyDown (KeyCode.E)) 
		{
			_animator.SetBool ("isopen", true);
		}

		if (collider.gameObject.tag == "Ivanoffee" & Input.GetKeyDown (KeyCode.F)) 
		{
			_animator.SetBool ("isopen", false);
		}
	}
*/		

/*
	void OnTriggerEnter(Collider collider) 
	{
		_animator.SetBool ("isopen", true);
	}

	void OnTriggerExit(Collider collider) 
	{
		_animator.SetBool ("isopen", false);
	}
*/
	