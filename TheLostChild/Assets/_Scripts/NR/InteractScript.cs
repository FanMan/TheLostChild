using UnityEngine;
using System.Collections;

public class InteractScript : MonoBehaviour 
{
	public float interactDistance = 5f;

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			Ray ray = new Ray(transform.position, transform.forward);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, interactDistance))
			{
				if (hit.collider.CompareTag("Door"))
				{
					DoorScript doorScript = hit.collider.transform.parent.GetComponent<DoorScript>();
					if (doorScript == null) return;

					if (Inventory.keys[doorScript.index] == true)
					{
						doorScript.ChangeDoorState();
					}
				}
				else if (hit.collider.CompareTag("Key"))
				{
					Inventory.keys[hit.collider.GetComponent<KeyScript>().index] = true;
					Destroy(hit.collider.gameObject);
				}
				else if (hit.collider.CompareTag("FlashLight"))
				{
					flashlight_light flashlight_Light = transform.Find("Spotlight").GetComponent<flashlight_light>();
					flashlight_Light.myLight.enabled=true;
					Destroy(hit.collider.gameObject);
				}
			}
		}
	}
}
