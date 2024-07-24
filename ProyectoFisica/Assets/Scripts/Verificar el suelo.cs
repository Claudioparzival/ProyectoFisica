using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verificarelsuelo : MonoBehaviour
{

    public static bool estaEnelSuelo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        estaEnelSuelo = true;   
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        estaEnelSuelo = false;  
    }













}
