using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlPlayer : MonoBehaviour
{
    public bool canMove;
    public float playerSpeed;
    public float jumpSpeed;
    public Joystick joystick;
    public int isJumping;
    public Animator animator;
    public GameObject restartGame1;
    public GameObject ctrlScript;

    public float move;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        canMove = true;
    }
    // Update is called once per frame
    void Update()
    {
        

        move = joystick.Horizontal;
        rb.velocity = new Vector2(move * playerSpeed, rb.velocity.y);
        animator.SetFloat("move", Mathf.Abs(joystick.Horizontal));

        if (move < 0 )
        {
            move = playerSpeed;
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (move > 0)
        {
            move = playerSpeed;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if(transform.position.y < -9.5)
        {
            
            restartGame1.SetActive(true);
        }
        


    }

    public void jump()
    {
        
        if (isJumping > 0)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeed));
            isJumping = isJumping - 1;
        }
        animator.SetFloat("isJumping", jumpSpeed / 1);


    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = 1;
        }
        animator.SetFloat("isJumping", -jumpSpeed);
       
      
        
    }

    
}
