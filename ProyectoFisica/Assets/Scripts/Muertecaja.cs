using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Muertecaja : MonoBehaviour
{


    public Rigidbody2D rb2D;

    public void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.gameObject.CompareTag("Player"))
        {
            other.transform.gameObject.GetComponent<Vidas>().TomarDa�o(1);
            Debug.Log("hola mundo");
        }
    }
}
