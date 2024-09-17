using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 7;
    public float rotationSpeed = 250;
    public Animator animator;

    private float x, y;

    void Update()
    {
        // Obtener las entradas del jugador
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        // Movimiento y rotación
        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * runSpeed);

        // Configurar parámetros de movimiento en el Animator
        // Asegúrate de que estos parámetros existan en el Animator
        animator.SetFloat("Vex", x);
        animator.SetFloat("VeY", y);

        // Activar animación de baile con la tecla "B"
        if (Input.GetKeyDown(KeyCode.B))
        {
            animator.SetTrigger("isDancing");  // Asegúrate de que 'isDancing' está configurado en el Animator
        }
    }
}
