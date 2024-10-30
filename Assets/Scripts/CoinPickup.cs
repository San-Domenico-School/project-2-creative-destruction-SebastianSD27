using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Coin") && gameManager != null)
       {
            gameManager.AddScore(.5f);
            
        }

            Destroy(other.gameObject);
    }
}
