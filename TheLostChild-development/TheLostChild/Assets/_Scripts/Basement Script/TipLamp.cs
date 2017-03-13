using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipLamp : MonoBehaviour
{
    AudioSource SoundEffect;

    public GameObject Lamp;
    public GameObject Object;
    public int WaitTime;

    void Awake()
    {
        SoundEffect = this.GetComponent<AudioSource>();
    }

    void OnTriggerExit(Collider C)
    {
        if(C.CompareTag("Player"))
        {
            Lamp.gameObject.transform.Rotate(new Vector3(0, 0, 13));
            Object.GetComponent<AudioSource>().Play();
            StartCoroutine(PlaySound());
        }
    }

    private IEnumerator PlaySound()
    {
        Debug.Log("Coroutine has started");

        // while the sound is playing, do nothing
        yield return new WaitForSeconds(WaitTime);

        // stop the sound effect
        SoundEffect.Stop();
        // decide whether to disable the object to prevent replay
        Object.SetActive(false);
    }
}
