using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class mover_enemiigo : MonoBehaviour
{

    public Rigidbody2D rb2D;

    public float velocidadDeMovimiento;

    public LayerMask capaAbajo;

    public LayerMask capaEnfrente;

    public float distanciaAbajo;

    public float distanciaEnfrente;

    public Transform controladorAbajo;

    public Transform controladorEnfrente;

    public bool informacionAbajo;

    public bool informacionEnfrente;

    public bool mirandoALaDerecha = true;








    // Update is called once per frame
    private void Update()
    {
        rb2D.velocity = new Vector2(velocidadDeMovimiento, rb2D.velocity.y);

        informacionEnfrente = Physics2D.Raycast(controladorEnfrente.position, transform.right, distanciaEnfrente, capaEnfrente);
        informacionAbajo = Physics2D.Raycast(controladorAbajo.position, transform.up * -1, distanciaAbajo, capaAbajo);


        if (informacionEnfrente)
        {
            girar();
        }


        if (!informacionAbajo)
        {
            girar();
        }
    }


    private void girar()
    {

        mirandoALaDerecha = !mirandoALaDerecha;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        velocidadDeMovimiento *= -1;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(controladorAbajo.transform.position, controladorAbajo.transform.position + transform.up * -1 * distanciaAbajo);
        Gizmos.DrawLine(controladorEnfrente.transform.position, controladorEnfrente.transform.position + transform.right* distanciaEnfrente);
    }
}
