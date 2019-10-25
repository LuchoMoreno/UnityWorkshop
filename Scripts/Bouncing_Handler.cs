using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncing_Handler : MonoBehaviour
{
    public GameObject char1;
    public GameObject char2;
    Bouncing_Mecanica BM1;
    Bouncing_Mecanica BM2;
    // Start is called before the first frame update
    void Start()
    {
        BM1 = char1.GetComponent<Bouncing_Mecanica>();
        BM2 = char2.GetComponent<Bouncing_Mecanica>();

    }

    // Update is called once per frame
    void Update()
    {
        if (BM1.grounded && BM2.sky)
        {
            BM2.activo = true;
            BM1.goUp();
        }
        if (BM1.sky && BM2.grounded)
        {
            BM1.activo = true;
            BM2.goUp();
        }
    }
}
