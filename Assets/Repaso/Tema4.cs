using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema4 : MonoBehaviour
{
    public int cantUnidades;
    public int dias;
    public int diasLluvia;
    // Start is called before the first frame update
    void Start()
    {
         int unidades = cantUnidades * 90;
        int unidadesLluvia = cantUnidades * 120;
        int litroComb = 15;
        int cantidadComb = (unidades + unidadesLluvia) / litroComb;
        int precioComb = cantidadComb * 130;
        int diasTotal = dias + diasLluvia;
        if (diasTotal < 5 && diasLluvia < 0)
        {
            Debug.Log("Error");
        }
        else
        {
            Debug.Log("Una flota de " + cantUnidades + " unidades trabajando durante " + diasTotal + " días implicará un gasto de " + precioComb + " pesos en concepto de combustible");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
