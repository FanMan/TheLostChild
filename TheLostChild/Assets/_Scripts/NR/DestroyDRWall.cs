using UnityEngine;
using System.Collections;

public class DestroyDRWall : MonoBehaviour 
{

	public static void DestroyGameObjectsWithTag(string DarkWall)
	{
		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(DarkWall);
		foreach (GameObject target in gameObjects) 
		{
			GameObject.Destroy(target);
		}
	}

}
