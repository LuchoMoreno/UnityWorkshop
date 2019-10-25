using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recolectar : MonoBehaviour
{
    public int recolectable;
    public Text showText;
    // Start is called before the first frame update
    void Start()
    {
        recolectable = 0;
      //  showText = GetComponent<Text>();
        showText.text = "" + recolectable.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Recolectable")
        {
            Destroy(other.gameObject);
            recolectable++;
            showText.text = "" + recolectable.ToString();

        }
    }
}
