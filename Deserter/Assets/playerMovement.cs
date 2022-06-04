using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float runningSpeed = 16f;
    public float walkingSpeed = 8f;
    public float speed = 8f;

    public float gravity = -20f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public LayerMask oasisMask;
    public bool isRunning = false;
    public bool isWalking = false;
    public bool isStanding = true;
    Vector3 velocity;
    bool isGrounded;
    bool isOnWater;
    public stats statistics;
    // Update is called once per frame
    void Update()
    {


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = runningSpeed;
            if (z != 0 || x != 0)
            {
                isRunning = true;
                isStanding = false;
                isWalking = false;

            }
            else
            {
                isStanding = true;
                isRunning = false;
                isWalking = false;
            }
        }
        else
        {
            if (z != 0 || x != 0)
            {
                isWalking = true;
                isRunning = false;
                isStanding = false;
            }
            else
            {
                isStanding = true;
                isWalking = false;
                isRunning = false;
            }
            speed = walkingSpeed;
        }
        



        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        isOnWater = Physics.CheckSphere(groundCheck.position, groundDistance, oasisMask);
        if(isOnWater)
        {
            statistics.water = 600;//max water
        }



        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}