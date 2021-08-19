using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour   
{
    public Character_Controller_2D controller;

    private float Horizontal_Movement = 0f;

    public float speed = 20f;

    bool jump = false;
    // Update is called once per frame
    void Update()
    {
        //input from player
        Horizontal_Movement = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

    }
    private void FixedUpdate()
    {
        //movement

        controller.Move(Horizontal_Movement * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
