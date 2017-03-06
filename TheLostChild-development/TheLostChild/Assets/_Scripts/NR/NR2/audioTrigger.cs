using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioTrigger : MonoBehaviour 
{
	AudioSource audio;
	bool alreadyPlayed = false;
	public AudioClip myAudio;

	void Start()
	{
		audio = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider collision) 
	{
		if (collision.gameObject.tag == "Ivanoffee") 
		{
			if (!alreadyPlayed)
			{
				audio.PlayOneShot (myAudio, 1);// 0-1 for volume
				alreadyPlayed = true; //make sure it only plays once
			}
		}
	}
	/*
	AudioSource audio = GetComponent<AudioSource>();

	void OnTriggerEnter(Collider collision) 
	{
		if (collision.gameObject.tag == "Ivanoffee") 
		{
			if (!audio.isPlaying)
			{
				audio.Play ();
			}
		}
	}
	*/
}
