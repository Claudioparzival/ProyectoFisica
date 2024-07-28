using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TransicionEscena : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void LoadScene(string scene)
    {
        StartCoroutine(Transiciona(scene));

    }
    
    
        IEnumerator Transiciona(string scene)
    {
        animator.SetTrigger("Salida");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(scene);
    }

    

}
