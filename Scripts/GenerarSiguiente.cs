using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarSiguiente : MonoBehaviour
{
    public int margenesCuadrados;
    public  GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        Vector3 posicion = new Vector3(Random.Range(-margenesCuadrados, margenesCuadrados), Random.Range(-margenesCuadrados, margenesCuadrados), 0);

       GameObject go = Instantiate(objeto, posicion, Quaternion.identity);
        go.SetActive(true);
        go.GetComponent<GenerarSiguiente>().enabled = true;
    }
}
