using System;
using Unity.Mathematics;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float sensibilidadMouse = 80f;

    public Transform playerBody;

    float xRotation = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidadMouse*Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y") * sensibilidadMouse * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Math.Clamp(xRotation, -90f, 90);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }


}
