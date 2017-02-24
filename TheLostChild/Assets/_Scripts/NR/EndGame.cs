using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour 
{
	/*
	public void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if(hit.gameObject.CompareTag ("EndBoundary"))
		{
			Application.LoadLevel("GameOver");
		}
	}*/

	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			Application.LoadLevel("GameOver");
		}
	}
}
