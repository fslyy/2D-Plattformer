using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour   
{
    public Character_Controller_2D controller;

    private float Horizontal_Movement = 0f;

    public float speed = 20f;

    public bool dashcooldown = false;
    public bool jump = false;
    public bool dash = false;
    

    void Update()
    {
        Horizontal_Movement = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (dashcooldown == false)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                dash = true;
                dashcooldown = true;
                Invoke("dashback", 2);
            }
        }

    }
    private void FixedUpdate()
    {

        controller.Move(Horizontal_Movement * Time.fixedDeltaTime, false, jump, dash);
        jump = false;
        dash = false;
    }
    public void dashback()
    {
        dashcooldown = false;
    }
}
