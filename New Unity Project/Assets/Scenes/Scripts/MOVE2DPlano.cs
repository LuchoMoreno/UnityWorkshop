using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE2DPlano : MonoBehaviour
{
    public float speed;                //Floating point variable to store the player's movement speed.
    float moveHorizontal;
    float moveVertical;

    // Use this for initialization
    void Start()
    {

  
        //Get and store a reference to the Rigidbody2D component so that we can access it.

    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void Update()
    {
        //Store the current horizontal input in the float moveHorizontal.
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical,0);

        transform.Translate(movement*speed);
    }
}
