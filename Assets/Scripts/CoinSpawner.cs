using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**************************************************
 * CoinSpawner class is attached to 
 * SpawnManager for player to collect
 * 
 * 
 * Sebastian Balakier
 * October 28, 2024 Version 1.0
 *************************************************/

public class CoinSpawner : MonoBehaviour
{
    private float spawnRange = 0.0f;
    private float spawnInterval = 5.0f;
    private float startDelay = 2.0f;
    [SerializeField] private GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCoins", startDelay, spawnInterval);
    }

    void SpawnCoins()
    {
        //int coinIndex = Random.Range(0, coin.Length);
        float xPosition = ((int)(Random.Range(0, 10) * 50 - 223)) / 10;
        Vector3 spawnPosition = new Vector3(xPosition, 0.0f, 6.2f);

        Instantiate(coin, spawnPosition, coin.transform.rotation);

    
    }
}