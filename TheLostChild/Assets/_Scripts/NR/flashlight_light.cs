using UnityEngine;
using System.Collections;

public class flashlight_light : MonoBehaviour {

	public Light myLight;

	void Start () 
	{
		myLight = GetComponent<Light> ();
		myLight.enabled = false;
	}

	void turnOn ()
	{
		myLight.enabled = true;
	}

	void Update () 
	{

	}
}
