using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema6 : MonoBehaviour
{
    public int entradasCampo;
    public int entradasPlatea;
    int recaudoCampo;
    int recaudoPlatea;
    // Start is called before the first frame update
    void Start()
    {
 if (entradasCampo <= 0)
        {
            Debug.Log("Las entradas del campo son invalidas");
        }
        else if (entradasCampo > 20400)
        {
            Debug.Log("La cantidad de entradas supera el espacio del campo");
        }
        else if (entradasPlatea <= 0)
        {
            Debug.Log("Las entradas de la platea son invalidas");
        }
        else if (entradasPlatea > 16200)
        {
            Debug.Log("La cantidad de entradas supera el espacio de la platea");
        }
        if (entradasCampo > 0 && entradasCampo < 20400)
        {
            {
                 recaudoCampo = entradasCampo * 1200;
                Debug.Log("La recaudacion total en el campo es de $" + recaudoCampo);
            }
            if (entradasPlatea > 0 && entradasPlatea < 16200)
            {
                recaudoPlatea = entradasPlatea * 2000;
                Debug.Log("La recaudacion total en la platea es de $" + recaudoPlatea);
            }
            int recaudoTotal = recaudoCampo + recaudoPlatea;
            Debug.Log("La recaudacion total es de $" + recaudoTotal);
            
            if (entradasCampo == 20400)
            {
                Debug.Log("Las entradas campo estan Sold Out!");
            }
            if (entradasPlatea == 16200)
            {
                Debug.Log("Las entradas platea estan Sold Out!");
            }
            if (entradasCampo < 20400)
            {
                int vacantesCampo = 20400 - entradasCampo;
                Debug.Log("Quedaron vacantes " + vacantesCampo + " entradas en el campo");
            }
            if (entradasPlatea < 16200)
            {
                int vacantesPlatea = 16200 - entradasPlatea;
                Debug.Log("Quedaron vacantes " + vacantesPlatea + " entradas en la platea");
            }
            if (entradasCampo > 10200 && entradasPlatea > 8100)
            {
                Debug.Log("El festival fue en un exito!");
            }
            else if (entradasCampo < 10200 && entradasPlatea < 8100)
            {
                Debug.Log("Debemos mejorar la convocatoria");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
