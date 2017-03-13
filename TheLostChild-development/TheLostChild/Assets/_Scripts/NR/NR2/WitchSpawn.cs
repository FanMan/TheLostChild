using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchSpawn : MonoBehaviour 
{
	public GameObject witch;

	void OnTriggerEnter (Collider collision) 
	{
		float lifespan = 3f;

		if (collision.gameObject.tag == "Ivanoffee") 
		{
			Destroy (witch, lifespan); //destroys the witch after 3seconds
		}
	}

}
