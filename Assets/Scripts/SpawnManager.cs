using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**************************************************
 * SpawnManager class is attached to Monobehavior
 * Spawns in player and animals to the scene
 * 
 * 
 * Sebastian Balakier
 * October 9, 2024 Version 1.0
 *************************************************/

public class SpawnManager : MonoBehaviour
{

    private float spawnRange = 15.0f;                              // distance to edge from center of field
    private float startDelay = 0.0f;                       // time before first spawn
    private float spawnInterval = 0.5f;                    // interval between spawns
    private float[] spawnPositionsX = { -34.5f, -29.0f, -24.0f, -19.5f, -14.3f, -9.3f, -4.5f, };
    [SerializeField] private GameObject[] car;         // list of cars to spawn

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCars", startDelay, spawnInterval);
    }

    // Adds a random animal at a random point between the spawn ranges
    void SpawnRandomCars()
    {
        int carIndex = Random.Range(0, car.Length);
        float xPosition = ((int) (Random.Range(0, 10) * 50 - 223)) / 10;
        Vector3 spawnPosition = new Vector3(xPosition, 0.0f, 60.0f);
        GameObject animal = car[carIndex];

        Instantiate(animal, spawnPosition, animal.transform.rotation);
    }
}