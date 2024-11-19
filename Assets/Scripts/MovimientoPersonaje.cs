using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovimientoPersonaje : MonoBehaviour
{
    // Variables publicas para el CharacterControlle, de nombre "controller" y una variable del tipo Float publico de valor 10 llamada "speed".
    //Ambas variables al ser publicas, puede ser modificadas desde el editor de Unity. Al aumentar la variable "speed" el personaje se movera mas rápido.

    public CharacterController controller;

    public float speed = 10f;


    //Variable float de la gravedad
    public float gravity = -9.8f;

    //variable float para la altura del salto
    public float AlturaSalto = 3;

    //componente transform del groundcheck
    public Transform groundCheck;

    //Variable float que determina la distancia que nos encontramos del suelo
    public float groudDistance = 0.3f;

    //Variable para identificar la capa del suelo
    public LayerMask ground;

    //Variable con valores en los 3 ejes para la velocidad
    Vector3 velocity;

    //variable del tipo bool (verdadero o falso) para determinar si estamos o no en el suelo
    bool isGrounded;

    //variable de stamina

    public float Stamina = 100f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //SISTEMA DE MOVIMIENTO
        //variables del tipo float para los ejes x y z que se toman a partir del iput horizontal y vertical, es decir, las teclas W,A,S y D o las fechitas.
        float x= Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //el personaje se mueve hacia los costados segun el input en X y hacia adelante y atras segun el input en Z

        Vector3 move = transform.right * x + transform.forward * z;

        //la velocidad de movimiento segun la variable speed

        controller.Move(move*speed*Time.deltaTime);

        //ajustar la velocidad de movimiento segun time.deltatime
        controller.Move(velocity * Time.deltaTime);

        //SISTEMA DE SALTO
        //si el groundchek está en contacto con el suelo, el bool isGrounded es verdadero
        isGrounded = Physics.CheckSphere(groundCheck.position, groudDistance, ground);

        //alterar la velocidad de la gravedad en el suelo 
        if (isGrounded && velocity.y<0)
        {
            velocity.y = -2f;
        }

        //saltar usando espacio si estamos en el suelo

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(AlturaSalto * -2f * gravity);
            
        }

        //ajustar la velocidad de Y segun el valor de la gravedad y time.deltatime. Esto hace que caigamos constante mente hacia abajo
        velocity.y += gravity * Time.deltaTime;





        //para correr



        if (Input.GetKey(KeyCode.LeftShift) && Stamina > 0f)
        {
            speed = 30f;
            Stamina -= 1f;
        }

        else
        {
            speed = 10f;
            
        }

        if (!Input.GetKey(KeyCode.LeftShift) && Stamina < 100f) 
        {
            Invoke("RecuperarStamina", 1f);
        }



    }

    private void RecuperarStamina()
    {
        Stamina += 0.01f;
    }

}
