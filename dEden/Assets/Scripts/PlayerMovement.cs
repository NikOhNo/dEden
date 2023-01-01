using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //Movespeed (SerializeField makes input box on unity)
    [SerializeField]
    private float moveSpeed;

    // Private property
    private Vector2 moveInput;

    // Get input from gamers
    void OnMove(InputValue value)
    {
        // moveInput variable set to value set by gamers push button 
        moveInput = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
       // Game object set to currentPos variable (get)
       Vector3 currentPos = transform.position;

        // newPos variable set to vector calculations
        // Time.deltaTime is amount of time between frames
        // moveSpeed is multiplied to time and input
       Vector3 newPos = new Vector3(
            currentPos.x + moveInput.x * Time.deltaTime * moveSpeed,
            currentPos.y + moveInput.y * Time.deltaTime * moveSpeed,
            0f);

       // Move player (set)
       transform.position = newPos;
        
    }
}
