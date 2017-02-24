using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour 
{
	public Light light;
	public AudioClip on;
	public AudioClip off;
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.LeftShift))//user "input" in this case Shift key to turn
												//flashlight on or off
		{
			if (light.enabled == false)
			{
				light.enabled = true;//turns flashlight on
				GetComponent<AudioSource>().clip = on;
				GetComponent<AudioSource>().Play();
			}
						
			else
			{
				light.enabled = false;//turns flashlight off
				GetComponent<AudioSource>().clip = off;
				GetComponent<AudioSource>().Play();
			}
		
		}
	}
}
