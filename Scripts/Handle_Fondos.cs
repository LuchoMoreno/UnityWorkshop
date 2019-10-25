using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle_Fondos : MonoBehaviour
{
   public GameObject f1;
    public GameObject f2;
    public int velocidad;
    // Start is called before the first frame update
    Vector3 posInicial;
    Vector3 posFinal;
    void Start()
    {
        posInicial = f2.transform.position;
        posFinal = -f2.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        f1.transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        f2.transform.Translate(Vector3.back * velocidad*Time.deltaTime);


        if (f1.transform.position.y < posFinal.y)
        {
            f1.transform.position = posInicial;
        }  
        if (f2.transform.position.y < posFinal.y)
        {
            f2.transform.position = posInicial;

        }

    }
}
