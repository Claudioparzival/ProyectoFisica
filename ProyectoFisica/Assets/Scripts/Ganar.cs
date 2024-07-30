using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganar : MonoBehaviour
{
    // Este método se llama cuando el jugador entra en el área del Trigger Collider
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Aquí puedes realizar acciones cuando el jugador entra en el área
            // Por ejemplo, terminar el juego o mostrar un mensaje
            Debug.Log("¡Jugador entró en el área!");
        }
    }
}