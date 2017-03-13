using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasementKeyScript : MonoBehaviour
{

    public GameObject BasementDoor;
    private bool isIntersecting;

	void Start () {
        isIntersecting = false;
	}
	
    void OnTriggerEnter(Collider C)
    {
        if(C.CompareTag("Player"))
        {
            isIntersecting = true;
            print(isIntersecting);
        }
    }

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E) && isIntersecting)
        {
            BasementDoor.SetActive(true);
            print("Basement is now available");
        }
    }
}
