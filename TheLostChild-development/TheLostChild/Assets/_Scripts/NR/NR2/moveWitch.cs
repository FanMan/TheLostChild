using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWitch : MonoBehaviour 
{
	public GameObject witch;

	public GameObject startPosition;

	public GameObject endPosition;

	public float movementSpeed = 0.75f;

	void OnTriggerEnter (Collider collision) 
	{
		float lifespan = 3f;

		if (collision.gameObject.tag == "Ivanoffee") 
		{
			//float frames = movementSpeed * Time.deltaTime;
			//witch.transform.Translate (Quaternion.Slerp(startPosition.transform.position, endPosition.transform.position, movementSpeed));
			witch.transform.position = Vector3.MoveTowards (witch.transform.position, endPosition.transform.position, movementSpeed);
			Destroy (witch, lifespan); //destroys the witch after 3seconds

		}
	}
}
