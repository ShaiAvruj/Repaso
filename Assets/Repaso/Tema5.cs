using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema5 : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public string nombre3;
    public int precio1;
    public int precio2;
    public int precio3;
    public int cant1;
    public int cant2;
    public int cant3;
        
    // Start is called before the first frame update
    void Start()
    {
        int precioUnidad1 = precio1 * cant1;
        int precioUnidad2 = precio2 * cant2;
        int precioUnidad3 = precio3 * cant3;
        if (precio1 < 1 && precio2 < 1 && precio3 < 1 && cant1 < 1 && cant2 < 1 && cant3 < 1)
        {
            if(cant1 > 3 && cant2 > 3 && cant3 > 3)
            {
                int precioDescuento1 = (20 / 100) * precioUnidad1;
                int precioDescuento2 = (20 / 100) * precioUnidad2;
                int precioDescuento3 = (20 / 100) * precioUnidad3;
            }
        }
        else
        {
            Debug.Log("Error los precios del producto y las cantidades de este deben ser mayor o igual a 1");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
