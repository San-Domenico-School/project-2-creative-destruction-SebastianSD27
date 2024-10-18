using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/**************************************************
 * PlayerController class is attached to Monobehavior
 * Controls the player's movements and actions
 * 
 * 
 * Sebastian Balakier
 * October 9, 2024
 *************************************************/



public class PlayerController : MonoBehaviour

{

    [SerializeField] private GameObject projectile;
    private float maxSpeed = 30.0f;
    private float centerToEdge = 20.0f;
    private float move;
    float newPositionX;

    // Start is called before the first frame update
    void Start()
    {
        maxSpeed = 30.0f;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
   

        float newPositionX = transform.position.x + move * maxSpeed * Time.deltaTime;

        if (newPositionX > centerToEdge)
        {
            newPositionX = centerToEdge;
        }

        else if (newPositionX < -centerToEdge)
        {
            newPositionX = -centerToEdge;

        }

        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }

    private void OnMove(InputValue input)
    {
        Vector2 inputVector = input.Get<Vector2>();
        move = inputVector.x;
    }

    private void OnFire()
    {
        Instantiate(projectile, transform.position + Vector3.up, projectile.transform.rotation);
    }

}
