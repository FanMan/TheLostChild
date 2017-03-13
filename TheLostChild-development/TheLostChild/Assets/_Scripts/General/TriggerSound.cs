using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    AudioSource SoundEffect;
    public GameObject Object;
    public int WaitTime;
    public bool KeepActive;

    void Start()
    {
        SoundEffect = this.GetComponent<AudioSource>();
    }

    void OnTriggerEnter()
    {
        SoundEffect.Play();
        Debug.Log("Sound is now playing");
        StartCoroutine(PlaySound());
    }

    private IEnumerator PlaySound()
    {
        Debug.Log("Coroutine has started");

        // while the sound is playing, do nothing
        yield return new WaitForSeconds(WaitTime);

        // stop the sound effect
        SoundEffect.Stop();
        // decide whether to disable the object to prevent replay
        Object.SetActive(KeepActive);        
    }
}
