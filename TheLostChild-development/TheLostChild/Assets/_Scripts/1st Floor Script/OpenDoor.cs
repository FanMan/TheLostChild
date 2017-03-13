using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
	GameObject Door;

	void Start ()
	{
		Door = this.gameObject;
        OpenTheDoor();
	}


	void OpenTheDoor ()
	{
        Door.transform.localRotation = Quaternion.AngleAxis(45, Vector3.up);
	}
}
