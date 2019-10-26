using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Municion : MonoBehaviour
{
    public bool MovVertical;
    public int velocidad;

    Vector2 mov;

    private void Start()
    {
        Invoke("Destruir", 5f);
        if (MovVertical)
        {
            mov = new Vector2(0, 1);
        }
        else {
            mov = new Vector2(1, 0);
        }
    }


    private void Destruir()
    {
        Destroy(this.gameObject);

    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(mov*Time.deltaTime*velocidad);
    }
}
