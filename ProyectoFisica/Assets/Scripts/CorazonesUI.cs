using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class CorazonesUI : MonoBehaviour
{

    public List<Image> listaCorazones;

    public GameObject corazonPrefab;

    public Vidas vida;

    public int indexActual;

    public Sprite corazonLleno;

    public Sprite corazonVacio;



    private void Awake()
    {
        vida.cambioVida.AddListener(CambiarCorazones);
    }

    private void CambiarCorazones(int vidaActual)
    {
        if (!listaCorazones.Any())
        {
            CrearCrazones(vidaActual);
        }
        else
        {
            cambiarVida(vidaActual);
        }
    }

    private void cambiarVida(int cantidadMaximaVida)
    {
        for (int i = 0; i < cantidadMaximaVida; i++)
        {
            GameObject corazon = Instantiate(corazonPrefab, transform);

            listaCorazones.Add(corazon.GetComponent<Image>());
        }

        indexActual = cantidadMaximaVida - 1;
    }

    private void CrearCrazones(int vidaActual)
    {

    }
}