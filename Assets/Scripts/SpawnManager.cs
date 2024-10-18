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
    private float startDelay = 5.0f;                       // time before first spawn
    private float spawnInterval = 0.5f;                    // interval between spawns
    [SerializeField] private GameObject[] animals;         // list of animals to spawn

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Adds a random animal at a random point between the spawn ranges
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange, spawnRange), 0.0f, 25.0f);
        GameObject animal = animals[animalIndex];

        Instantiate(animal, spawnPosition, animal.transform.rotation);
    }
}