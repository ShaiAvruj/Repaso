using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ010 : MonoBehaviour
{
    public int entradasCampo;
    public int entradasPlatea;
    int recaudoCampo;
    int recaudoPlatea;
    // Start is called before the first frame update
    void Start()
    { 
        int recaudoTotal = recaudoCampo + recaudoPlatea;
        int vacanteCampo = 20400 - entradasCampo;
        int vacantePlatea = 16200 - entradasPlatea;

        if (entradasCampo <= 0)
        {
            Debug.Log("¡Error!, la cantidad de entradas debe ser un numero mayor a 0");
        }
        else if (entradasCampo > 20400)
        {
            Debug.Log("¡Error!, la cantidad de entradas supera al tamaño del campo");
        }
        else if (entradasPlatea <= 0)
        {
            Debug.Log("¡Error!, la cantidad de entradas debe ser un numero mayor a 0");
        }
        else if (entradasPlatea > 16200)
        {
            Debug.Log("¡Error!, la cantidad de entradas supera al tamaño de la platea");
        }
        else if (entradasCampo > 0 && entradasCampo < 20400 && entradasPlatea > 0 && entradasPlatea < 16200)
        {
            recaudoTotal = recaudoCampo + recaudoPlatea;
           recaudoCampo = entradasCampo * 1200;
            recaudoPlatea = entradasPlatea * 2000;
            Debug.Log("La recaudacion en campo es de $" + recaudoCampo + ".");
            Debug.Log("La recaudacion en platea es de $" + recaudoPlatea + ".");
            Debug.Log("La recaudacion total es de $" + recaudoTotal + ".");
            Debug.Log("El espacio que quedo vacante en el campo es de " + vacanteCampo + " entradas");
            Debug.Log("El espacio que quedo vacante en la platea es de " + vacantePlatea + " entradas");
        }
        else if (entradasCampo == 20400)
        {
            Debug.Log("Campo: Sold Out!");
        }
        else if (entradasPlatea == 16200)
        {
            Debug.Log("Platea: Sold Out!");
        }
        else if (entradasCampo > 10200)
        {
            Debug.Log("El festival fue un exito!");
        }
        else if (entradasCampo < 10200)
        {
            Debug.Log("Debemos mejorar la convocatoria");
        }
        else if (entradasPlatea > 8100)
        {
            Debug.Log("El festival fue un exito!");
        }
        else if (entradasPlatea < 8100)
        {
            Debug.Log("Debemos mejorar la convocatoria");
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
