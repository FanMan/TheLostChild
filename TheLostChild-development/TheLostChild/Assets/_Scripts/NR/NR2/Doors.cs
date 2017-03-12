using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour 
{
	public float timeleft = 0; //how long it takes for the door to open

	public RaycastHit hit; //checks to see if the door is hit

	public Transform currentdoor; //our door

	public bool open; //check if door is open

	public bool IsOpeningDoor; //if it is opening a door, it cant open another door (wont open 2 doors)

	public Transform cam;

	public LayerMask mask;//mask to check which layers it can hit

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.E) && timeleft == 0.0f) 
		{
			CheckDoor ();
		}

		if (IsOpeningDoor) 
		{
			OpenAndCloseDoor ();
		}
	}

	public void CheckDoor()
	{
		if (Physics.Raycast (cam.position, cam.forward, out hit, 5, mask)) 
		{
			//checks to see if we are hitting a door
			open = false; 
			if (hit.transform.localRotation.eulerAngles.y > 45) 
			//checks if door is already open
				open = true;
				IsOpeningDoor = true;
				currentdoor = hit.transform;
		}
	}

	public void OpenAndCloseDoor()
	{
		timeleft += Time.deltaTime;

		if (open) 
			//want a nice animation we use quaternion slerp: here we want to close the door
			currentdoor.localRotation = Quaternion.Slerp (currentdoor.localRotation, Quaternion.Euler (0, 0, 0), timeleft);
			//currentdoor.localPosition = Quaternion.Slerp (currentdoor.localPosition, Quaternion.Euler (0, 0, 0), timeleft);
		
		else 
			currentdoor.localRotation = Quaternion.Slerp (currentdoor.localRotation, Quaternion.Euler (0, 90, 0), timeleft);

		if (timeleft > 1) 
		{
			timeleft = 0; //reset the time left otherwise itll keep incrementing and act weird
			IsOpeningDoor = false; //it isnt opening the door anymore
		}
	}
}
