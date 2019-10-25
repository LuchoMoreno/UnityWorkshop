using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * 6);
        if (Input.GetKey(KeyCode.K))
        {
            Debug.Log("ww");
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * 6);
            
        }
    }
}
