using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public BoxCollider2D myBody;

    public float moveSpeed = 5f;
    private float horizontalMovement = 0f;
    // Start is called before the first frame update
    void Start() 
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myBody = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        float flipX = Input.GetAxisRaw("Horizontal");

        if (flipX != 0)
        {
            FlipPlayer(flipX);
        }
    }

    private void FlipPlayer(float flipX)
    {
        transform.localScale = new Vector2(flipX, transform.localScale.y);
    }

    private void FixedUpdate()
    {
        myRigidBody.velocity = new Vector2(horizontalMovement * moveSpeed, myRigidBody.velocity.y);
    }
}
