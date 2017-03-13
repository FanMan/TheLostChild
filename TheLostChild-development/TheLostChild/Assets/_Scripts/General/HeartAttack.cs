using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartAttack : MonoBehaviour
{
    AudioSource HeartBeat;

    public void Awake()
    {
        HeartBeat = this.GetComponent<AudioSource>();
        HeartBeat.volume = 0;
    }

    void Start()
    {
        HeartBeat = this.GetComponent<AudioSource>();
        HeartBeat.volume = 0;
    }

    void Update()
    {
        // the lose condition
        if (HeartBeat.volume == 1.0f)
        {
            Debug.Log("Game Over");
        }
    }

    public void StartHeartBeat()
    {
        HeartBeat.Play();
    }

    public void StopHeartBeat()
    {
        HeartBeat.Stop();
    }

    public void IncreaseHeartBeat(float JumpScare)
    {
        // if the volume of the heart beat was at zero, start playing
        if (HeartBeat.volume == 0 && JumpScare > 0)
        {
            HeartBeat.Play();
            HeartBeat.loop = true;
            HeartBeat.volume = JumpScare;
        }
        else if (HeartBeat.volume > 0 && JumpScare == 0)
        {
            HeartBeat.Stop();
            HeartBeat.volume = 0;
        }
    }
}
