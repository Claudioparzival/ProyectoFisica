using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muertecaja : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.gameObject.CompareTag("Player"))
        {
            other.transform.gameObject.GetComponent<Vidas>().TomarDa�o(1);
            Debug.Log("hola mundo");
        }
    }
}
