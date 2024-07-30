using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Vidas : MonoBehaviour
{


    public int vidaActual;

    public int vidaMaxima;

    public UnityEvent<int> cambioVida;

    public int valorPrueba;

    public event EventHandler MuerteJugador;
    private void Start()
    {
        cambioVida.Invoke(vidaActual);

    }

    



   

    // Update is called once per frame
    public void TomarDaño(int cantidadDaño)
    {
        int vidaTemporal = vidaActual - cantidadDaño;


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

    public void MuerteJugadorEvento()
    {
        MuerteJugador?.Invoke(this, EventArgs.Empty);
    }


}
