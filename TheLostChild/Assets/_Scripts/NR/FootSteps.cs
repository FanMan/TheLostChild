using UnityEngine;
using System.Collections;

public class FootSteps : MonoBehaviour 
{
	CharacterController character;

	// Use this for initialization
	void Start () 
	{
		character = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (character.isGrounded == true && character.velocity.magnitude > 2f && GetComponent<AudioSource>().isPlaying == false) 
		{
			//Mess around with volume and pitch to make it sound more realistic
			//audio.volume = Random.Range (1f, 1);
			//audio.pitch = Random.Range(1f, 1.1f);
			GetComponent<AudioSource>().Play();
		}
	}
}
