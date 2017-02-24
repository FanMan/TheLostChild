using UnityEngine;
using System.Collections;

public class FlickeringLight : MonoBehaviour {

	public float minTime = 0.05f;//default time; makes sure it flickers in seconds not by frames
	public float maxTime = 1.2f;//default time; makes sure it flickers in seconds noy by frames

	private float timer;//keeps track of the min and max times
	private Light lightSource;//the light source

	void Start () 
	{
		lightSource = GetComponent<Light>();
		timer = Random.Range(minTime, maxTime);
	}
	
	void Update () 
	{
		timer -= Time.deltaTime;//keeps track of the min and max times by seconds not frames
		if(timer <= 0)//keep flickering the light if the timer is not set to 0, it will never be for our project
		{
			lightSource.enabled = !lightSource.enabled;
			GetComponent<AudioSource>().Play();//plays audio when lightSource is on, in this case it will always be on
			timer = Random.Range(minTime, maxTime);//sets random time in seconds for when to flicker light based on min and max
		}
	}
}