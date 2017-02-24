using UnityEngine;
using System.Collections;

public class pickUpFlashLight : MonoBehaviour 
{
	private bool hasFlashLight= false; // has got a flashlight?
	private Light FlashLight; // reference to the flashlight
	private GameObject pickup; // reference to the pick up item
		
	void  OnTriggerEnter ( Collider other  )
	{ 	// if entered pickup trigger...
		if (other.CompareTag("FlashLight"))
		{ // remember to tag the flashlight!
			pickup = other.gameObject; // save reference to the pickup game object
		}
	}
	
	void  OnTriggerExit ( Collider other  )
	{ // if exited pickup trigger...
		if (other.CompareTag("FlashLight"))
		{
			pickup = null; // null the reference
		}
	}
		void  Start ()
		{
			// find the light attached to the camera...
			FlashLight = GetComponentInChildren<Light>();
			FlashLight.enabled = true; // and make sure it's off
		}
		
		void  Update ()
		{
			// if inside pickup trigger and E pressed...
			if (pickup && Input.GetKeyDown("E")){
				hasFlashLight = true; // flashlight picked up
				Destroy(pickup); // destroy pick up item
			}
			// if has got flashlight and Shift is pressed...
			if (hasFlashLight && Input.GetKeyDown("LeftShift")){
				// toggle flashlight on/off 
				FlashLight.enabled = !FlashLight.enabled;
			}
	}
}

