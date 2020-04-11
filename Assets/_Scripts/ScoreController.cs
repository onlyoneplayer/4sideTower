using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public static ScoreController singleton;

    public int scoreAmount;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreFinalText;
    public TextMeshProUGUI highestScoreText;

    private void Awake()
    {
        singleton = this;
    }

    private void Start()
    {
        //move to ui controller
        scoreText.text = "0";

        highestScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();

    }

    public void AddScore()
    {
        scoreAmount++;
        scoreText.text = scoreAmount.ToString();

        if(scoreAmount > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", scoreAmount);
        }
    }

    public void UpdateFinalScore()
    {
        scoreFinalText.text = scoreAmount.ToString();
        highestScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
