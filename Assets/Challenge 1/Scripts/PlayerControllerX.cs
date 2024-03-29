﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 10;
    private float rotationSpeed = 50;
    private float verticalInput;

    public float horizontalInput;
    public GameObject propeller;
    private float propSpeed = 2000;

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, verticalInput * rotationSpeed * Time.deltaTime);

        // Rotates the propeller
        propeller.transform.Rotate(Vector3.forward, propSpeed * Time.deltaTime);
        

        //get user horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        //bouge l'avion sur le coté
        transform.Rotate(Vector3.forward, horizontalInput * rotationSpeed * Time.deltaTime * -1);
        transform.Rotate(Vector3.right, horizontalInput * rotationSpeed * Time.deltaTime * 1);

    }
}
