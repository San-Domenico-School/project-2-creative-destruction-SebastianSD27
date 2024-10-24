using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**************************************************
 * MoveForward class is attached to Monobehavior
 * Moves the animals forward
 * 
 * 
 * Sebastian Balakier
 * October 9, 2024
 *************************************************/

public class MoveForward : MonoBehaviour
{

    [Range(1, 30)]
    [SerializeField] private float speed;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

}
