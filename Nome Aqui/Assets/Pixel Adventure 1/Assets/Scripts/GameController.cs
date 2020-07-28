using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameController : MonoBehaviour
{

    public int Score;
    public static int totalScore;
    public static int deaths;

    public Text scoreText;

    public GameObject gameOver;

    public static GameController instance;

    private int scoreForLvl;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        scoreText.text = totalScore.ToString();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void UpdateScoreText()
    {
        scoreForLvl += Score;
        totalScore += Score;
        scoreText.text = totalScore.ToString();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvlName)
    {
        deaths++;
        totalScore = totalScore - scoreForLvl;
        SceneManager.LoadScene(lvlName);
    }
}
