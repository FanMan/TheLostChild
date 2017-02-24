using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float WalkSpeed;
    public float RotationSpeed;

    private float HorizontalInput, VerticalInput;               // x and z axis movement of the player
    private float dt;                                           // variable to reuse DeltaTime instead of calling Time.DeltaTime all over the place
    private Vector3 PlayerMovement;                             // Vector3 to store the position of the player
    private CharacterController Player;                         // Using CharacterController instead of RigidBody for now

    void Start()
    {
        HorizontalInput = 0;
        VerticalInput = 0;
        dt = 0;
        PlayerMovement = new Vector3(0, 0, 0);
        Player = GetComponent<CharacterController> ();
    }

    // Update is called once per frame
    void Update()
    {
        dt = Time.deltaTime;

        // if the player is not grounded, apply gravity
        if(!Player.isGrounded)
        {
            PlayerMovement.y = -9.8f;
        }

        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        PlayerMovement.x = HorizontalInput * WalkSpeed;
        PlayerMovement.z = VerticalInput * WalkSpeed;

        Player.Move(PlayerMovement * dt);
    }
}
