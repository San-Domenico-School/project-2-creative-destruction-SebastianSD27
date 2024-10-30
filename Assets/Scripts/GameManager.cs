using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/****************************************
 * Attached to Game Manager empty.  Updates the 
 * score
 * 
 * Sebastian
 * Version 1.0
 * 
 ****************************************/

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private float score = 0;
    
    

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    public void AddScore(float addTo)
    {
        score = score + addTo;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    public void EndGame()
    {
        Time.timeScale = 0;
    }
}
