using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
	public int NextScene;
    public int TriggerNumber;
    GameManager GM;

    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager> ();
    }

	void OnTriggerEnter(Collider C)
	{
		if(C.CompareTag("Player"))
		{
            GM.SetPlayerPositionOnSceneTransition(NextScene, TriggerNumber);
		}
	}
}
