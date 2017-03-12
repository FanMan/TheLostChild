using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OCDoors : MonoBehaviour 
{
	public float speed = 2f;

	void OnTriggerEnter(Collider collider)
	{
		print ("in trigger");
		if (collider.gameObject.tag == "Ivanoffee") 
		{
			Quaternion targetRotation = Quaternion.Euler(0, 90, 0);
			gameObject.transform.rotation = Quaternion.Slerp (transform.localRotation, targetRotation, Time.deltaTime * speed);
			print ("after rotation");
		} 

	}		
}
