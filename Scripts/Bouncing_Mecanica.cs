using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing_Mecanica : MonoBehaviour
{

    Rigidbody rb;
    public bool activo;
    public bool grounded;
    public bool sky;
    public int velocidad;
    public GameObject char1;
    Bouncing_Mecanica BM;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        BM = char1.GetComponent<Bouncing_Mecanica>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if (activo) { 
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0);
        transform.Translate(movement * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.Space) && sky)
            {
                rb.isKinematic = false;
                rb.useGravity = true;
            }

        }

    }

    public void goUp()
    {
        rb.isKinematic = false;
        rb.AddForce(Vector3.up * velocidad,ForceMode.Impulse);
        activo = true;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "piso")
        {
            BM.goUp();
            activo = false;
            grounded = true;
         
            rb.useGravity = false;
            rb.isKinematic = true;


        }
        if (collision.transform.name == "sky")
        {
            sky = true;
          
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.name == "piso")
        {
            grounded = false;
            sky = false;
         
        }

        if (collision.transform.name == "sky")
        {
         
            sky = false;
            grounded = false;
        }
    }

}
