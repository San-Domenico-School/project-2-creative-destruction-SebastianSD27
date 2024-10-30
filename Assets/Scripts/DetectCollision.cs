using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**************************************************
 * DetectCollision class is attached to Monobehavior
 * Senses when a GameObject collides with another
 * 
 * 
 * Sebastian Balakier
 * October 9, 2024
 *************************************************/

 public class DetectCollision : MonoBehaviour
{

    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            gameManager.EndGame();
        }

    }

}
