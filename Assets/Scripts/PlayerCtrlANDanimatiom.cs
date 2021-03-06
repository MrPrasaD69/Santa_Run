using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnCtrlAndAnimation : MonoBehaviour
{
    public float playerSpeed;
    public float jumpSpeed;
    public Joystick joystick;
    private int isJumping;

    private float move;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent < Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        move = joystick.Horizontal;
            rb.velocity = new Vector2(move * playerSpeed, rb.velocity.y);

        if(move < 0 )
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if(move > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        
    }

    public void jump()
    {
        if (isJumping>0)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
            isJumping = isJumping - 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = 2;
        }
    }
}
