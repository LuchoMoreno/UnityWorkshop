using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE3DSpaceShip : MonoBehaviour
{
    public float speed;                //Floating point variable to store the player's movement speed.

    public GameObject municion;

    void Start()
    {
        
        //Get and store a reference to the Rigidbody2D component so that we can access it.

    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void Update()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        transform.Translate(movement * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(municion,this.transform);

        }


    }
}
