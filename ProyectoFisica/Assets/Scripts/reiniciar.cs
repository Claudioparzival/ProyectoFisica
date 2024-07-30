using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class reiniciar : MonoBehaviour
{



    [SerializeField] private GameObject menu;

    private Vidas vida;


    public void Start()
    {
        vida = GameObject.FindGameObjectWithTag("Player").GetComponent<Vidas>();
        vida.MuerteJugador += AbrirMenu;
    }


    public void AbrirMenu(object sender, EventArgs e)
    {
         menu.SetActive(true);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
