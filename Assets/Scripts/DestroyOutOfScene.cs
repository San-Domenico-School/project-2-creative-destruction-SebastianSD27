using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 /**************************************************
 * DestroyOutOfScene class is attached to Monobehavior
 * Destroys GameObjects that are out of the scene
 * 
 * 
 * Sebastian Balakier
 * October 9, 2024
 *************************************************/

public class DestroyOutOfScene : MonoBehaviour

{

    private float UpperBound;
    private float LowerBound;

   // Start is called before the first frame update
   void Start()
   {
        UpperBound = 30.0f;
   }

    // Update is called once per frame
    void Update()
   {
        DestroyOutOfBounds();
   }

    void DestroyOutOfBounds()
   {
        LowerBound = -6.0f;

        if (transform.position.z > UpperBound)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < LowerBound)
        {
            Debug.Log("Game Over");
        }
   }

}
