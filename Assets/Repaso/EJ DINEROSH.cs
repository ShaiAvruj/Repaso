using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJDINEROSH : MonoBehaviour
{
    public int dinero = 0;
    public string moneda = "";
    // Start is called before the first frame update
    void Start()
    {
        int dolares = dinero / 200;
        int realess = dinero / 24;
        int euros = dinero / 210;
        if (dinero < 1000)
        {
            Debug.Log("Debes tener al menos 1000 pesos");
        }
        else if (dinero >= 1000)
        {
            switch (moneda)
            {
                case "D":
                    Debug.Log("Tenes $" + dolares);
                    break;

                case "R":
                    Debug.Log("Tenes $ " + realess);
                    break;

                case "E":
                    Debug.Log("Tenes $" + euros);
                    break;

                default:
                    Debug.Log("Pone una moneda valida");
                    break;


            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
