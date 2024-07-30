using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEditor;

public class Ganar : MonoBehaviour

{


    [SerializeField] private GameObject Win;
    // Este método se llama cuando el jugador entra en el área del Trigger Collider
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Aquí puedes realizar acciones cuando el jugador entra en el área
            // Por ejemplo, terminar el juego o mostrar un mensaje
            Victoria();
            Debug.Log("¡Jugador entró en el área!");
        }
    }

    public void Victoria()
    {
        Win.SetActive(true);
    }
}