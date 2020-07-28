using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Pontuação: " + GameController.totalScore.ToString() + "\nMorreu: " + GameController.deaths;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void End_Game(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }

    public void Quit()
    {
            Application.Quit();
    }

}
