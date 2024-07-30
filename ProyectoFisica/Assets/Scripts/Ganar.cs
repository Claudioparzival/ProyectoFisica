using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganar : MonoBehaviour
{
    // Este m�todo se llama cuando el jugador entra en el �rea del Trigger Collider
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Aqu� puedes realizar acciones cuando el jugador entra en el �rea
            // Por ejemplo, terminar el juego o mostrar un mensaje
            Debug.Log("�Jugador entr� en el �rea!");
        }
    }
}