using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour   
{
    public Character_Controller_2D controller;

    private float Horizontal_Movement = 0f;

    public float speed = 20f;

    public float dashcooldown = 5f;


    bool jump = false;
    bool dash = false;


    // Update is called once per frame
    void Update()
    {
        //input from player
        Horizontal_Movement = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (dashcooldown < 0)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                dash = true;
                dashcooldown = 5f;
            }
        }

    }
    private void FixedUpdate()
    {
        //movement

        controller.Move(Horizontal_Movement * Time.fixedDeltaTime, false, jump, dash);
        jump = false;
        dash = false;
        dashcooldown -= 5 * Time.deltaTime;
    }
}
