using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ010 : MonoBehaviour
{
    public int hora;
    bool abierto = false;
    // Start is called before the first frame update
    void Start()
    {
        if (hora < 18 && hora > 10)
        {
            abierto = true;
        }
        switch (abierto)
        {

            case false:
                Debug.Log("El estacionamiento se encuentra cerrado");
                break;

            default:
                Debug.Log("El estacionamiento se encuentra abierto");
                break;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
