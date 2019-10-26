using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE2D : MonoBehaviour
{
    public float speed;                //Floating point variable to store the player's movement speed.

    SpriteRenderer sp;     //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public Vector3 juump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    Rigidbody2D rb;

    void OnCollisionStay2D()
    {
        isGrounded = true;
    }

    void OnCollisionExit2D()
    {
        isGrounded = false;
    }

    // Use this for initialization
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        //Get and store a reference to the Rigidbody2D component so that we can access it.

    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, 0);

        if (moveHorizontal < 0)
        {
            sp.flipX = true;
        }
        else if (moveHorizontal > 0) {
            sp.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded || Input.GetKey(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(juump * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        transform.Translate(movement * Time.deltaTime);
    }
}
