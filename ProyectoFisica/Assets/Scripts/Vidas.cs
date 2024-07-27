using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Vidas : MonoBehaviour
{


    public int vidaActual;

    public int vidaMaxima;

    public UnityEvent<int> cambioVida;

    public int valorPrueba;
    
    private void Start()
    {
        vidaActual = vidaMaxima = 0;
        cambioVida.Invoke(vidaActual);

    }


   

    // Update is called once per frame
    public void TomarDa�o(int cantidadDa�o)
    {
        int vidaTemporal = vidaActual - cantidadDa�o;


        if (vidaTemporal < 0)
        {
            vidaActual = 0;

        }
        else
        {
            vidaActual = vidaTemporal;
        }
        
        cambioVida.Invoke(vidaActual);

        if (vidaActual <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void CurarVida(int cantidadCuracion)
    {
        int vidaTemporal = vidaActual + cantidadCuracion;

        if (vidaTemporal > vidaMaxima)
        {
            vidaActual = vidaMaxima;
        }
        else
        {
            vidaActual = vidaTemporal;
        }
    }
}
