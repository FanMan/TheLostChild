using UnityEngine;
using System.Collections;

public class BarrierTrigger : MonoBehaviour 
{
	public  GameObject barrier;

	public void OnTriggerEnter()
	{
		Destroy (barrier);
	}

}
