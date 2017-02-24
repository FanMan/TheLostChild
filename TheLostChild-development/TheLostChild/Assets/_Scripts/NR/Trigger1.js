#pragma strict

 var face : GameObject;

 var hasPlayed = false;
 var enterTrigger = false;
 
 var dialogue : AudioClip; 

function Start () 
{
	enterTrigger = false;
	face.GetComponent.<Renderer>().enabled = false;
}
	function OnTriggerEnter (other : Collider)
	{
		enterTrigger = true;
	} 



function Update () 
{
		if(enterTrigger == true)
		{
			face.GetComponent.<Renderer>().enabled = true;
			removeovertime ();
			queueDialogue();
		}
}

function removeovertime ()
{
	yield WaitForSeconds(9);
	face.GetComponent.<Renderer>().enabled = false;
}

function queueDialogue ()
{
	if(!hasPlayed)
	{
		hasPlayed = true;
		GetComponent.<AudioSource>().PlayOneShot(dialogue);
	}
}