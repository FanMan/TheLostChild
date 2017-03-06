using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterial : MonoBehaviour 
{
	public Material newMaterial;

	void OnTriggerEnter(Collider collision) 
	{
		if (collision.gameObject.tag == "Ivanoffee") 
		{
			//print ("collided");
			//GameObject.FindWithTag("Wall2Change").GetComponent<Renderer>().material = newMaterial;//doesnt work with more than one
			GameObject.Find("Bedroom Wall Westa").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall West (1)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("HWall (1)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall West (2)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall West (7)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall South (1)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall West (5)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall West (4)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall Westb").GetComponent<Renderer>().material = newMaterial;
			print ("left side complete");


			GameObject.Find("HWall").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall East (2)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall West (6)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall East3a").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall Northa1").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("HWall (2)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall South (4)").GetComponent<Renderer>().material = newMaterial;

			GameObject.Find("Bedroom Wall West (11)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall South (2)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall South (3)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall Westa2").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall Southa1").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall East (1)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall East (3)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall West (10)").GetComponent<Renderer>().material = newMaterial;
			GameObject.Find("Bedroom Wall East2a").GetComponent<Renderer>().material = newMaterial;


		}
	}

}
