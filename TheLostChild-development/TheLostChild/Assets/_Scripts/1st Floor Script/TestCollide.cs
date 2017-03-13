using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollide : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision c)
    {
        print("collision happened");
        if (c.gameObject.CompareTag("Player"))
        {
            print("Kart collision");
        }
    }
}
