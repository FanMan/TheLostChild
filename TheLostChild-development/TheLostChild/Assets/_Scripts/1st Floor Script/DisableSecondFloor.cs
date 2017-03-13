using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableSecondFloor : MonoBehaviour
{
    GameObject SecondFloorTransition;
    private bool canPass;
    
	void Start () {
        SecondFloorTransition = gameObject;
        canPass = false;
	}

    void OnTriggerEnter(Collider C)
    {
        if(C.CompareTag("Player"))
        {
            // play dialogue
        }
    }
    
    // call this after doing a certain event in the basement;
    void EnableSecondFloor()
    {
        // enables the Script component to allow for transition
        SecondFloorTransition.GetComponent<SceneTransition>().enabled = true;
    }
}
