using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject gameOverUI;
    private bool gameOver = false;
    void Start()
    {
        UpdateScore();
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int points)
    {
        score += points;
        UpdateScore();
       
    }
    private void UpdateScore()
    {
        scoreText.text = " " + score;
    }
    public void GameOver()
    {
        gameOver = true;
        score = 0;
        Time.timeScale = 0;
        gameOverUI.SetActive(true);

    }

}
