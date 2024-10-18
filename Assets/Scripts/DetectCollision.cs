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

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
