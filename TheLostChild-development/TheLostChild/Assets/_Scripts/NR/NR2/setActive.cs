using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActive : MonoBehaviour 
{
	public GameObject myObject; 
	public GameObject myObject2; 

	void OnTriggerEnter(Collider collision) 
	{
		if (collision.gameObject.tag == "Ivanoffee") 
		{
			myObject.SetActive (true);
			myObject2.SetActive (true);
		}
	}

}
