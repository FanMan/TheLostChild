using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour 
{
	public int index = -1;
	public bool open = false;
	public float doorOpenAngle = 90f;
	public float doorCloseAngle = -90f;
	public float smooth = 2f; //how fast the door opens

	void Start () 
	{
	
	}
	
	public void ChangeDoorState()
	{
		open = !open;
	}
	void Update () 
	{
		if (open) 
		{
			Quaternion targetRotation = Quaternion.Euler(doorOpenAngle, 0, 0);
			transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
		} 
		else 
		{
			Quaternion targetRotation2 = Quaternion.Euler(doorCloseAngle, 0, 0);
			transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime);
		}
	}
}
