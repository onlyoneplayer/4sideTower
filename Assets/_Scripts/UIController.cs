using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIController : MonoBehaviour
{
    public GameObject finalScreen;
    public GameObject scoreInGame;
    public Button restartButton;

    private void Awake()
    {
        finalScreen.SetActive(false);
        restartButton.onClick.AddListener(RestartGame);
    }

    public void ShowFinalScreen()
    {
        ScoreController.singleton.UpdateFinalScore();
        scoreInGame.SetActive(false);
        finalScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
