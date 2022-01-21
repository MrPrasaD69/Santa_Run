using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoyCtrl : MonoBehaviour
{
    public Joystick joystick;

    public Rigidbody2D rb;

    Vector2 movement;

    public float speed = 5f; //speed of player
    // Update is called once per frame
    void Update()
    {
        //JOYSTICK INPUT
        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
