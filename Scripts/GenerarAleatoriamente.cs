using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarAleatoriamente : MonoBehaviour
{
    public List<GameObject> spots;
    public GameObject objeto;
    public float frecuencia;
    public bool espaciosAleatorios;
    public bool esperarASerAgarrado;
    public int margenesCuadrados;
 
    // Start is called before the first frame update
    void Start()
    {
        if (espaciosAleatorios)
        {
            if (esperarASerAgarrado) {

            } else
            {
                Invoke("GenerarEnEspacio",frecuencia);
            }
        }
        else
        { // no espaciosAleatorios  -> spots
            Invoke("GenerarPorSpots", frecuencia);

        }
    }

    void GenerarPorSpots() {

        int index = Random.Range(0, spots.Count);
        Vector3 posicion = spots[index].transform.position;

        Instantiate(objeto, posicion,Quaternion.identity);
        Invoke("GenerarPorSpots", frecuencia);

    }

    void GenerarEnEspacio()
    {

        Vector3 posicion = new Vector3(Random.Range(-margenesCuadrados, margenesCuadrados), Random.Range(-margenesCuadrados, margenesCuadrados), 0);

        Instantiate(objeto, posicion, Quaternion.identity);
        Invoke("GenerarEnEspacio", frecuencia);

    }



}
