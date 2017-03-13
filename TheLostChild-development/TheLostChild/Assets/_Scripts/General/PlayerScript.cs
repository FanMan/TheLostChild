using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public static PlayerScript Player;

    void Awake()
    {
        if (Player == null)
        {
            DontDestroyOnLoad (Player);
            Player = this;
        }
        else if (Player != this)
        {
            Destroy (Player);
        }
    }
}
