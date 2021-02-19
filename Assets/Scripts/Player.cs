using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask WhatIsGround;
    private bool grouned;
    private bool doubleJump;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator> ();
    }

    void FixedUpdate()
    {
        grouned = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, WhatIsGround);
    }

    // Update is called once per frame
    void Update()
    {

        if(grouned)
        doubleJump = false;
        anim.SetBool("Grounded",grouned);

        if(Input.GetKeyDown(KeyCode.W) && grouned)
        {
            Jump ();
        }

        if(Input.GetKeyDown(KeyCode.W) && !grouned && !doubleJump)
        {
            Jump ();
            doubleJump = true;
        }

        if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        anim.SetFloat ("Speed", Mathf.Abs (GetComponent<Rigidbody2D> ().velocity.x));
        
    }
    
    void Jump()
    
    {
         GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, jumpHeight);
    }
}
